--region 一、建立数据库
CREATE DATABASE BookStore
ON PRIMARY(
    name='BookStore_data',
    filename='D:\Projects\SQLServer\BookStore\BookStore_data.mdf',
    size = 10MB,
    MAXSIZE = UNLIMITED,
    filegrowth=5MB
    )
LOG ON(
    name = 'BookStore_log',
    filename='D:\Projects\SQLServer\BookStore\BookStore_log.ldf',
    size = 10MB,
    MAXSIZE = UNLIMITED,
    filegrowth=5MB
    )
GO
--endregion

--region 二、建表
USE BookStore

--会员信息：（会员账号，姓名，手机号，余额，冻结余额，会员状态，备注）
--进货订单：（进货单号，书籍号码，进货数量，单价，进货日期，备注）
--销售清单：（日期，书籍号码，数量，销售单价，备注）
--书籍信息：（书籍号码，书名，类别，作者，书籍照片，照片格式，库存数量, 全新数量，当前售价,书籍简介,备注）
--书籍Item：（书籍ID，书籍号码，书籍状态，备注）
--充值记录：（充值单号,日期，会员账号，充值金额，备注）
--赔偿记录：（书籍ID，会员账号，赔偿金额，赔偿日期，备注）
--租借记录：（租借号，会员账号，书籍ID，租借日期，是否续租，应还日期，备注）
--已归还表：（租借号，会员账号，书籍ID，租借日期，归还日期，备注）

--1.建会员表
CREATE TABLE memberData(
    memberID char(8) PRIMARY KEY,
    memberName nvarchar(10) Not NULL,
    memberPhoneNumber char(11) UNIQUE Not Null,
    memberOverage money DEFAULT 0 check(memberOverage >= 0) Not Null,
    memberFreezeOverage money DEFAULT 0 check(memberFreezeOverage >= 0) Not Null,
    memberState nvarchar(2) check(memberState IN (N'正常',N'注销')) DEFAULT N'正常' Not Null,
    Remarks nvarchar(max) DEFAULT NULL
)

--2.建进货表
CREATE TABLE Purchase(
    PurchaseID char(6),
    BookISBN char(13) FOREIGN KEY REFERENCES BookData(BookISBN) ON UPDATE CASCADE,
    Amount int NOT NULL,
    BookPrice money NOT NULL,
    PurchaseDate DateTime NOT NULL DEFAULT GETDATE(),
    Remarks nvarchar(max) DEFAULT NULL,
    PRIMARY KEY (PurchaseID, BookISBN)
)

--3.建销售表
CREATE TABLE Sell(
    SellDate DateTime NOT NULL DEFAULT GETDATE(),
    BookISBN char(13) Not NULL FOREIGN KEY REFERENCES BookData(BookISBN) ON UPDATE CASCADE,
    SellNum int Not NULL DEFAULT 1 check(SellNum > 0),
    SellPrice money NOT NULL check(SellPrice > 0),
    Remarks nvarchar(max) DEFAULT NULL
)

--4.建书籍表
CREATE TABLE BookData(
    BookISBN char(13) PRIMARY KEY,
    BookName nvarchar(25) NOT NULL,
    BookAuthor nvarchar(15) NOT NULL,
    BookCategory nvarchar(10) DEFAULT NULL,
    BookPicture image DEFAULT NULL,
    PictureFormat nvarchar(5) DEFAULT NULL,
    BookNum int NOT NULL check (BookNum >=0),
    BrandNewBookNum int NOT NULL check (BrandNewBookNum >=0),
    BookPrice money NOT NULL check (BookPrice >=0),
    BookSummary varbinary(max) DEFAULT NULL,
    Remarks nvarchar(max) DEFAULT NULL
)

--5.建书籍Item表
CREATE TABLE ITEMS(
    BookID char(7) PRIMARY KEY,
    BookISBN char(13) NOT NULL FOREIGN KEY REFERENCES BookData(BookISBN) ON UPDATE CASCADE,
    BookStatus varchar(3) check (BookStatus in (N'被租借',N'在店',N'已丢失')) NOT NULL DEFAULT N'在店',
    Remarks nvarchar(max) DEFAULT NULL
)

--6.建充值表
CREATE TABLE Recharge(
    RechargeID char(10) PRIMARY KEY,
    RechargeDate DateTime NOT NULL DEFAULT GETDATE(),
    memberID char(8) NOT NULL FOREIGN KEY REFERENCES memberData(memberID),
    RechargeMoney money NOT NULL check (RechargeMoney >=0),
    Remarks nvarchar(max) DEFAULT NULL
)

--7.建赔偿表
CREATE TABLE Compensate(
    BookID char(7) NOT NULL Foreign KEY REFERENCES Items(BookID),
    memberID char(8) NOT NULL FOREIGN KEY REFERENCES memberData(memberID),
    CompensateMoney money NOT NULL check (CompensateMoney > 0),
    CompensateData DateTime NOT NULL DEFAULT GETDATE(),
    Remarks nvarchar(max) DEFAULT NULL
)

--8.建租借表
CREATE TABLE Lease(
    LeaseID char(10) PRIMARY KEY,
    memberID char(8) FOREIGN KEY REFERENCES memberData(memberID),
    BookID char(7) NOT NULL Foreign KEY REFERENCES Items(BookID),
    LeaseDate DateTime NOT NULL DEFAULT GETDATE(),
    WhetherLeaseRenew nchar(1) CHECK(WhetherLeaseRenew in (N'是', N'否')) DEFAULT N'否',
    DueDate DateTime NOT NULL DEFAULT DATEADD(day,30,GETDATE()) check(DATEDIFF(day,GETDATE(),DueDate)>0),
    Remarks nvarchar(max) DEFAULT NULL
)

--9.建已归还表
CREATE TABLE Returns(
    LeaseID char(10) PRIMARY KEY,
    memberID char(8) FOREIGN KEY REFERENCES memberData(memberID),
    BookID char(7) NOT NULL Foreign KEY REFERENCES Items(BookID),
    LeaseDate DateTime NOT NULL,
    ReturnData DateTime NOT NULL DEFAULT GETDATE(),
    Remarks nvarchar(max) DEFAULT NULL
)

--endregion

--region 三、创建视图

-- 1.会员拓展视图(会员账号、总充值金额、现租借图书数量)
-- 2.逾期未归还图书视图(姓名、手机号、书籍名、应还日期)
-- 3.库存过少书籍(书籍号码、书名、库存数量、全新数量)
-- 4.本月销售清单(日期、书籍号码、书名、类别、销售金额)
-- 5.进货简化视图(进货单号、进货总数量、进货日期、进货总价)
-- 6.租借拓展视图(租借号、会员名、会员手机号、书名、租借日期、是否续借、租借截止日期)
-- 7.图书拓展视图(书籍号码、书名、书籍类别、书籍作者、库存数量、全新数量、图书价格、销售数量、租借次数)
-- 8.销售拓展视图(日期、书籍号码、书名、类别、销售数量、销售金额)
-- 9.创建图书-Items视图(除了Items.Remark都有)

--region 1.会员拓展视图
GO
create view memberView as
    select A.memberID, AllRechargeMoney, (B.BorrowingBook + C.BorrowingBook) BorrowingBook
    from (select memberData.memberID, sum(RechargeMoney) AllRechargeMoney from memberData, Recharge where memberData.memberID = Recharge.memberID and memberData.memberState=N'正常' group by memberData.memberID) as A,
         (select memberData.memberID, count(LeaseID) BorrowingBook from memberData, Lease where memberData.memberID = Lease.memberID group by memberData.memberID) as B,
         (select memberData.memberID, count(LeaseID) BorrowingBook from memberData, Returns where memberData.memberID = Returns.memberID group by memberData.memberID) as C
    where A.memberID = B.memberID
    and B.memberID = C.memberID
--endregion

--region 2.逾期未归还图书视图
GO
create view OverdueBook as
    select LeaseID,Lease.BookID,memberName,memberPhoneNumber,BookName,LeaseDate,WhetherLeaseRenew,DueDate
    from memberData,Lease,BookData,Items
    where memberData.memberID = Lease.memberID
    and Lease.BookID = Items.BookID
    and Items.BookISBN = BookData.BookISBN
    and 0>DATEDIFF(day,GETDATE(), Lease.DueDate)
    and memberData.memberState=N'正常'
--endregion

--region 3.库存过少图书
GO
create view LowInventory as
    select BookISBN, BookName, BookNum,BrandNewBookNum
    from BookData
    where BookNum<10
    or BrandNewBookNum<5
--endregion

---region 4.本月销售清单
GO
create view ThisMonthSSalesList as
    select SellDate,BookData.BookISBN,BookData.BookName,BookData.BookCategory,SellPrice
    from Sell,BookData
    where Sell.BookISBN = BookData.BookISBN
    and DATEDIFF(month,GETDATE(), Sell.SellDate)=0
--endregion

--region 5.进货简化视图
GO
create view PurchaseView as
    select PurchaseID,sum(Amount) sumCount,PurchaseDate,sum(Amount*BookPrice) sumMoney
    from Purchase
    group by Purchase.PurchaseID, PurchaseDate
--endregion

--region 6.现租借拓展视图
GO
create view LeaseView as
    select LeaseID,memberName,memberPhoneNumber,BookName,LeaseDate,WhetherLeaseRenew,DueDate
    from Lease, memberData, BookData, Items
    where memberData.memberID = Lease.memberID
    and Lease.BookID=Items.BookID
    and Items.BookISBN=BookData.BookISBN
--endregion

--region 7.图书拓展视图
GO
create view BookView as
    select A.BookISBN, A.BookName,A.BookCategory,A.BookAuthor,A.BookNum,A.BrandNewBookNum,A.BookPrice,A.SellCount SellCount,(B.LeaseCount+C.LeaseCount) LeaseCount, D.AtStoreCount
    from (select BookData.BookISBN, BookData.BookName,BookData.BookCategory,BookData.BookAuthor,BookData.BookNum,BookData.BrandNewBookNum,BookData.BookPrice,sum(Sell.SellNum) SellCount from BookData,Sell where BookData.BookISBN = Sell.BookISBN group by BookData.BookISBN,BookName,BookNum,BookCategory,BookAuthor,BrandNewBookNum,BookPrice) A,
         (select BookData.BookISBN,count(*) LeaseCount from BookData,Lease,Items where BookData.BookISBN=Items.BookISBN and Items.BookID = Lease.BookID group by BookData.BookISBN) B,
         (select BookData.BookISBN,count(*) LeaseCount from BookData,Returns,Items where BookData.BookISBN=Items.BookISBN and Items.BookID = Returns.BookID group by BookData.BookISBN) C,
         (select BookData.BookISBN,count(*) AtStoreCount from BookData,Returns,Items where BookData.BookISBN=Items.BookISBN and BookStatus = N'在店' group by BookData.BookISBN) D
    where A.BookISBN=B.BookISBN
    and B.BookISBN=C.BookISBN
    and C.BookISBN=D.BookISBN
--endregion

--region 8.销售拓展视图
GO
create view SellView as
    select SellDate,BookData.BookISBN,BookData.BookName,BookData.BookCategory,SellNum,SellPrice
    from Sell,BookData
    where Sell.BookISBN = BookData.BookISBN
--endregion

--region 9.创建图书-Items视图
Go
create view BookItemsView as
    select Items.BookID, ITEMS.BookISBN, ITEMS.BookStatus,
          BookData.BookName, BookData.BookAuthor, BookData.BookCategory, BookData.BookPicture, BookData.PictureFormat, BookData.BookNum, BookData.BrandNewBookNum, BookData.BookPrice, BookData.BookSummary, BookData.Remarks
           from BookData,Items where BookData.BookISBN = Items.BookISBN
--endregion
--endregion

--region 四、添加索引

--1.  会员手机号添加唯一索引
--2.  进货订单书籍号码添加索引
--3.  销售清单书籍号码添加索引
--4.  书籍信息书名添加索引
--5.  书籍信息作者添加索引
--6.  充值记录会员账号添加索引
--7.  赔偿记录会员账户添加索引
--8.  赔偿记录书籍号码添加索引
--9.  租借记录会员账号添加索引
--10. 租借记录书籍号码添加索引
--11. 已归还书籍号码添加索引
--12. 已归还会员账号添加索引

--region 1.会员手机号添加唯一索引
create UNIQUE
INDEX PhoneNumberIndex
ON memberData(memberPhoneNumber)
--endregion

--region 2.进货订单书籍号码添加索引
create Index PurchaseIndex
on Purchase(BookISBN)
--endregion

--region 3.销售清单书籍号码添加索引
create Index SellIndex
on Sell(BookISBN)
--endregion

--region 4.书籍信息书名添加索引
create Index BookNameIndex
on BookData(BookName)
--endregion

--region 5.书籍信息作者添加索引
create Index BookAuthorIndex
on BookData(BookAuthor)
--endregion

--region 6.充值记录会员账号添加索引
create Index RechargeMemberIDIndex
on Recharge(memberID)
--endregion

--region 7.赔偿记录会员账户添加索引
create Index CompensateMemberIdIndex
on Compensate(memberID)
--endregion

--region 8.赔偿记录书籍号码添加索引
create Index CompensateBookISBNIndex
on Compensate(BookID)
--endregion

--region 9.租借记录会员账号添加索引
create Index LeaseMemberIDIndex
on Lease(memberID)
--endregion

--region 10.租借记录书籍号码添加索引
create Index LeaseBookISBNIndex
on Lease(BookID)
--endregion

--region 11. 已归还书籍号码添加索引
Create Index ReturnsBookISBNIndex
on Returns(BookID)
--endregion

--region 12. 已归还会员账号添加索引
Create Index ReturnsMemberIDIndex
on Returns(MemberID)
--endregion

--endregion

--region 五、创建触发器
-- 触发器：审核、数据同步功能，当写入某个数据时检查数据是否合理，是否与其他数据冲突、且同步其他表中数据
--1.修改续租状态时修改应还日期
--2.删除归还记录时修改库存数量、冻结余额，并将数据转移到returns
--3.插入租借记录时修改库存数量、冻结余额
--4.插入销售清单时修改全新数量
--5.插入进货订单时修改全新数量
--6.插入充值记录时修改会员信息
--7.插入赔偿记录时修改书籍库存信息、冻结金额和余额，并删除租借图书记录，修改Items状态

--region 1.修改续租状态时修改应还日期
Go
Create TRIGGER alterLeaseRenew
on Lease
AFTER Update
as
    begin
        if Update(WhetherLeaseRenew)
            begin
                declare @NewDueData DateTime
                declare @WhetherLeaseRenew char(1)
                declare @LeaseID char(10)
                select @NewDueData = DATEADD(day,60,inserted.LeaseDate),@WhetherLeaseRenew = inserted.WhetherLeaseRenew,@LeaseID = inserted.LeaseID from inserted
                if @WhetherLeaseRenew=N'是'
                    begin
                        update Lease
                        set Lease.DueDate = @NewDueData
                        where Lease.LeaseID = @LeaseID
                    end
            end
    end
--endregion

--region 2.插入已归还表时，删除归还记录，并修改库存数量、冻结余额
GO
CREATE TRIGGER insertReturns
on Returns
after insert
as
    begin
        declare @memberID char(8)
        declare @BookID char(7)
        declare @LeaseDate DateTime
        declare @BookPrice money
        declare @BookISBN char(13)
        declare @LeaseID char(10)
        declare @LeaseDay int

        select @LeaseID = LeaseID,@BookID = BookID,@memberID = MemberID,@LeaseDate = LeaseDate from inserted

        --Delete Lease Data
        delete from Lease where LeaseID = @LeaseID

        set @LeaseDay = DATEDIFF(day,@LeaseDate,GETDATE())

        select @BookPrice = BookPrice,@BookISBN = BookISBN
        from BookItemsView where BookID= @BookID

        --Update Book count
        update BookData
        set BookNum = BookNum+1
        where BookData.BookISBN = @BookISBN

        --Update Member Overage
        update memberData
        set memberFreezeOverage -= @BookPrice,
            memberOverage += (@BookPrice - @LeaseDay*0.1)
        where memberData.memberID = @memberID
end
--endregion

--region 3.插入租借记录时修改库存数量、冻结余额
Go
CREATE TRIGGER insertLeaseData
on Lease
after INSERT
as
    begin
        declare @memberID char(8)
        declare @BookID char(7)
        declare @BookISBN char(13)
        declare @BookPrice money

        select @memberID = inserted.memberID,@BookID = inserted.BookID from inserted
        select @BookPrice = BookPrice,@BookISBN = BookISBN
        from BookItemsView where BookID = @BookID

        if exists (select * from Lease,BookItemsView where BookISBN = @BookISBN and Lease.memberID = @memberID and Lease.BookID = BookItemsView.BookID)
            begin
                rollback transaction;
            end

        update BookData
        set BookNum -= 1
        where BookData.BookISBN = @BookISBN

        update memberData
        set memberFreezeOverage += @BookPrice
        where memberData.memberID = @memberID
    end
--endregion

--region 4.插入销售清单时修改全新数量、库存数量
GO
CREATE TRIGGER insertSellData
on Sell
after insert
as
    begin
        declare SellCursor cursor FORWARD_ONLY static
        for select BookISBN,SellNum from inserted

        declare @BookISBN char(13)
        declare @BookNum int

        open SellCursor

        fetch next from SellCursor into @BookISBN,@BookNum

        While @@fetch_status = 0
            begin
                update BookData
                set BookNum -= 1,
                    BrandNewBookNum -= 1
                where BookData.BookISBN = @BookISBN
                fetch next from SellCursor into @BookISBN,@BookNum
            end
        close SellCursor
        deallocate SellCursor
    end
--endregion

--region 5.插入进货订单时修改全新数量
Go
CREATE TRIGGER insertPurchaseData
on Purchase
after insert
as
    begin
        declare PurchaseCursor CURSOR FORWARD_ONLY static
        for select BookISBN,Amount from inserted

        declare @BookISBN char(13)
        declare @Amount int

        open PurchaseCursor
        fetch next from PurchaseCursor into @BookISBN,@Amount
        while @@fetch_status = 0
        begin
            update BookData
            set BookNum += @Amount,
                BrandNewBookNum += @Amount
            where BookData.BookISBN = @BookISBN
            fetch next from PurchaseCursor into @BookISBN,@Amount
        end
        close PurchaseCursor
        deallocate PurchaseCursor
    end
--endregion

--region 6.插入充值记录时修改会员信息
Go
CREATE TRIGGER insertRechargeData
on Recharge
after insert
as
    begin
        declare @memberID char(8)
        declare @RechargeMoney money
        select @memberID = inserted.memberID,@RechargeMoney = inserted.RechargeMoney from inserted

        update memberData
        set memberOverage += @RechargeMoney
        where memberData.memberID = @memberID
    end
--endregion

--region 7.插入赔偿记录时修改书籍库存信息、冻结金额和余额，并删除租借图书记录，修改Items状态
Go
CREATE TRIGGER insertCompensateData
on Compensate
after insert
as
    begin
        declare @memberID char(8)
        declare @BookISBN char(13)
        declare @CompensationMoney money
        declare @BookID char(7)

        select @memberID = inserted.memberID,@BookID = inserted.BookID,@CompensationMoney = inserted.CompensateMoney from inserted

        select @BookISBN = BookISBN from BookItemsView where BookItemsView.BookID = @BookID

        update BookData
        set BookNum -= 1
        where BookData.BookISBN = @BookISBN

        update memberData
        set memberOverage -= @CompensationMoney,
            memberFreezeOverage -= @CompensationMoney
        where memberData.memberID = @memberID

        update ITEMS
        set BookStatus = N'已丢失'
        where @BookID = Items.BookID

        delete from Lease
        where Lease.memberID = @memberID
        and Lease.BookID= @BookID

        delete from Items
        where Items.BookID = @BookID
    end
--endregion

--endregion

-- region 六、创建函数
-- 函数：必须有返回值、用来拓展标准SQL语句，可以嵌入SQL语句中
--1.获得会员总人数
--2.获得本年总充值记录数
--3.获得本年本月总租借数
--4.获得下一个Items的ID

--region 1.获得会员总人数
Go
Create Function getAllMembersNum()
returns int
as
    begin
        declare @count int
        select @count = count(*) from memberData
        return @count
    end
--endregion

--region 2.获得本年总充值记录数
Go
create function getYearRechargeCount()
returns int
as
    begin
        declare @count int
        select @count = count(*) from Recharge
        where DATEPART(year,Recharge.RechargeDate) = DATEPART(year,GETDATE())
        return @count
    end
--endregion

--region 3.获得本年本月总租借数
Go
create function getThisMonthLeaseCount()
returns int
as
    begin
        declare @count int
        select @count = count(*) from Lease
        where DATEPART(year,Lease.LeaseDate) = DATEPART(year,GETDATE())
        and DATEPART(month,Lease.LeaseDate) = DATEPART(month,GETDATE())
        return @count
    end
--endregion

--region 4.获得下一个Items的ID
Go
Create Function getNextID(@BookISBN char(13))
returns char(7)
as
    begin
        declare @count int
        select @count = count(*) from Items where Items.BookISBN = @BookISBN
        return replace(str(@count,7),'','0')
    end
--endregion

--endregion

--region 七、存储过程
-- 存储过程：对某些功能进行封装， 避免了程序和数据库通信时传输大量代码
--1.获得某一时间段销售记录
--2.通过手机号获得某会员租借记录
--3.通过会员ID获得某会员租借记录
--4.通过手机号获得某会员赔偿记录
--5.通过会员ID获得某会员赔偿记录
--6.通过手机号获得某会员充值记录
--7.通过会员ID获得某会员充值记录
--8.获得某一时间段进货清单
--9.根据某一进货单号获得具体进货信息
--10.根据图书号码获得某一图书具体信息
--11.根据图书名获得匹配到的所有图书
--12.根据作者名获得匹配到的所有图书
--13.根据类别获得匹配到的所有图书
--14.根据会员名获得匹配到的所有会员
--15.根据会员手机号匹配会员
--16.根据会员ID匹配会员
--17.根据图书名和作者名搜索图书
--18.根据图书名和类别搜索图书
--19.根据作者名和类别搜索图书
--20.根据图书名、作者名和类别搜索图书
--21.修改某一书籍用于租借的数量存储过程


--region 1.获取某一时间段销售记录
Go
CREATE PROCEDURE getPartTimeSellData
    @beginTime DateTime,
    @endTime DateTime = NULL
as
    begin
        if @endTime is NULL
            set @endTime = GETDATE()
        select *
        from SellView
        where DATEDIFF(day,@beginTime,SellView.SellDate)>0
        and DATEDIFF(day,SellView.SellDate,@endTime)>0
    end
--endregion

--region 2.通过手机号获得某会员租借记录
Go
CREATE PROCEDURE getLeaseDataByPhoneNumber
    @PhoneNumber char(11)
as
    begin
        select memberData.memberID,memberName,memberPhoneNumber,BookItemsView.BookISBN,BookName,Lease.LeaseDate
        from memberData,Lease,BookItemsView
        where memberData.memberID= Lease.memberID
        and Lease.BookID = BookItemsView.BookID
        and memberData.memberPhoneNumber = @phoneNumber
        union
        select memberData.memberID,memberName,memberPhoneNumber,BookItemsView.BookISBN,BookName,Returns.LeaseDate
        from memberData,Returns,BookItemsView
        where memberData.memberID= Returns.memberID
          and Returns.BookID = BookItemsView.BookID
          and memberData.memberPhoneNumber = @phoneNumber
    end
--endregion

--region 3.通过会员ID获得某会员租借记录
GO
CREATE PROCEDURE getLeaseDataByMemberID
    @memberID varchar(8)
as
    begin
        select memberData.memberID,memberName,memberPhoneNumber,BookItemsView.BookISBN,BookName
        from memberData,Lease,BookItemsView
        where memberData.memberID= Lease.memberID
        and Lease.BookID = BookItemsView.BookID
        and memberData.memberID like '%'+@memberID+'%'
        union
        select memberData.memberID,memberName,memberPhoneNumber,BookItemsView.BookISBN,BookName
        from memberData,Returns,BookItemsView
        where memberData.memberID= Returns.memberID
          and Returns.BookID = BookItemsView.BookID
          and memberData.memberID like '%'+@memberID+'%'
    end
--endregion

--region 4.通过手机号获得某会员赔偿记录
GO
CREATE PROCEDURE getCompensateDataByPhoneNumber
    @phoneNumber char(11)
as
    begin
        select memberData.memberID,memberName,memberPhoneNumber,BookItemsView.BookID,BookName
        from Compensate,memberData,BookItemsView
        where memberData.memberID = Compensate.memberID
        and BookItemsView.BookID = Compensate.BookID
        and memberData.memberPhoneNumber = @phoneNumber
    end
--endregion

--region 5.通过会员ID获得某会员赔偿记录
Go
CREATE PROCEDURE getCompensateDataByMemberID
    @memberID varchar(8)
as
    begin
        select memberData.memberID,memberName,memberPhoneNumber,BookItemsView.BookID,BookName
        from Compensate,memberData,BookItemsView
        where memberData.memberID = Compensate.memberID
        and BookItemsView.BookID = Compensate.BookID
        and memberData.memberPhoneNumber like '%'+@memberID+'%'
    end
--endregion

--region 6.通过手机号获得某会员充值记录
GO
CREATE PROCEDURE getRechargeDataByPhoneNumber
    @phoneNumber char(11)
as
    begin
        select memberData.memberID,memberName,memberPhoneNumber,RechargeID,RechargeDate,RechargeMoney
        from Recharge,memberData
        where memberData.memberID = Recharge.memberID
        and memberPhoneNumber = @phoneNumber
    end
--endregion

--region 7.通过会员ID获得某会员充值记录
GO
CREATE PROCEDURE getRechargeDataByMemberID
    @memberID varchar(11)
as
    begin
        select memberData.memberID,memberName,memberPhoneNumber,RechargeID,RechargeDate,RechargeMoney
        from Recharge,memberData
        where memberData.memberID = Recharge.memberID
        and memberData.memberID like '%'+@memberID+'%'
    end
--endregion

--region 8.获得某一时间段进货清单
Go
CREATE PROCEDURE getPartTimePurchaseData
    @beginTime DateTime,
    @endTime DateTime = NULL
as
    begin
        if @endTime IS NULL
            set @endTime = GETDATE()
        select PurchaseID,PurchaseDate,BookData.BookISBN,BookName,Purchase.BookPrice,Purchase.Amount
        from Purchase,BookData
        where BookData.BookISBN = Purchase.BookISBN
        and DATEDIFF(day,@beginTime,PurchaseDate)>0
        and DATEDIFF(day,PurchaseDate,@endTime)>0
    end
--endregion

--region 9.根据某一进货单号获得具体进货信息
Go
CREATE PROCEDURE getPurchaseDataByPurchaseId
    @PurchaseID varchar(6)
as
    begin
        select PurchaseID,PurchaseDate,BookData.BookISBN,BookName,Purchase.BookPrice,Purchase.Amount
        from Purchase,BookData
        where BookData.BookISBN = Purchase.BookISBN
        and PurchaseID like '%'+@PurchaseID+'%'
    end
--endregion

--region 10.根据图书号码获得某一图书具体信息
Go
CREATE PROCEDURE getBookSellDataByBookISBN
    @BookISBN varchar(13)
as
    begin
        select *
        from BookView
        where BookISBN like '%'+@BookISBN+'%'
    end
--endregion

--region 11.根据图书名获得匹配到的所有图书
Go
CREATE PROCEDURE getBookDataByBookName
    @BookName nvarchar(25)
as
    begin
        select *
        from BookView
        where BookName like '%'+@BookName+'%'
    end
--endregion

--region 12.根据作者名获得匹配到的所有图书
Go
CREATE PROCEDURE getBookDataByAuthor
    @Author nvarchar(15)
as
    begin
        select *
        from BookView
        where BookAuthor like '%'+@Author+'%'
    end
--endregion

--region 13.根据类别获得匹配到的所有图书
Go
CREATE PROCEDURE getBookDataByCategory
    @Category nvarchar(10)
as
    begin
        select *
        from BookView
        where BookCategory = @Category
    end
--endregion

--region 14.根据会员名获得匹配到的所有会员
Go
CREATE PROCEDURE getMemberDataByMemberName
    @memberName nvarchar(10)
as
    begin
        select *
        from memberData
        where memberName like '%'+@memberName+'%'
    end
--endregion

--region 15.根据会员手机号匹配会员
Go
CREATE PROCEDURE getMemberDataByPhoneNumber
    @phoneNumber char(11)
as
    begin
        select *
        from memberData
        where memberPhoneNumber = @phoneNumber
    end
--endregion

--region 16.根据会员ID匹配会员
Go
CREATE PROCEDURE getMemberDataByMemberID
    @memberID varchar(8)
as
    begin
        select *
        from memberData
        where memberID like '%'+@memberID+'%'
    end
--endregion

--region 17.根据图书名和作者名搜索图书
Go
CREATE PROCEDURE getBookDataByBookNameAndAuthor
    @BookName nvarchar(25),
    @Author nvarchar(15)
as
    begin
        select *
        from BookView
        where BookName like '%'+@BookName+'%'
        or @Author like '%'+@Author+'%'
    end
--endregion

--region 18.根据图书名和类别搜索图书
Go
CREATE PROCEDURE getBookDataByBookNameAndCategory
    @BookName nvarchar(25),
    @Category nvarchar(10)
as
    begin
        select *
        from BookView
        where BookName like '%'+@BookName+'%'
        and BookCategory = @Category
    end
--endregion

--region 19.根据作者名和类别搜索图书
Go
CREATE PROCEDURE getBookDataByAuthorAndCategory
    @Author nvarchar(15),
    @Category nvarchar(10)
as
    begin
        select *
        from BookView
        where BookAuthor like '%'+@Author+'%'
        and BookCategory = @Category
    end
--endregion

--region 20.根据图书名、作者名和类别搜索图书
Go
CREATE PROCEDURE getBookDataByBookName_AuthorAndCategory
    @BookName nvarchar(25),
    @Author nvarchar(15),
    @Category nvarchar(10)
as
    begin
        select *
        from BookView
        where BookName like '%'+@BookName+'%'
        or BookAuthor like '%'+@Author+'%'
        and BookCategory = @Category
    end
--endregion

--region 21.修改某一书籍用于租借的数量存储过程

Go
CREATE PROCEDURE AlterLeaseCountByBookISBN
    @BookISBN char(13),
    @Count int
as
begin
    declare @NowCount int
    declare @BookID char(7)
    select @NowCount = count(*) from BookItemsView where BookISBN = @BookISBN
    if @Count < @NowCount
    begin
        declare mycursor cursor scroll for select BookID from BookItemsView where BookISBN = @BookISBN
        open mycursor
        fetch last from mycursor into @BookID
        while @Count < @NowCount and @@FETCH_STATUS = 0
            begin
                delete from Items where BookID = @BookID
                set @NowCount = @NowCount - 1
                fetch PRIOR from mycursor into @BookID
            end
        close mycursor
        deallocate mycursor
    end
    else
    begin
        update BookData set BrandNewBookNum -= @Count - @NowCount where BookISBN = @BookISBN
        while @NowCount > @Count
        begin
            set @BookID = dbo.getNextID(@BookISBN)
            insert into Items(BookID,BookISBN)
            Values (@BookID,@BookISBN)
        end
    end
end
--endregion

--endregionbian