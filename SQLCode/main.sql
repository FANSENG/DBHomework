--region 一、建立数据库
CREATE DATABASE bookStoreDB
ON PRIMARY(
    name='bookStoreDB_data',
    filename='D:\Projects\SQLServer\bookStoreDB\bookStoreDB_data.mdf',
    size = 10MB,
    MAXSIZE = UNLIMITED,
    filegrowth=5MB
    )
LOG ON(
    name = 'bookStoreDB_log',
    filename='D:\Projects\SQLServer\bookStoreDB\bookStoreDB_log.ldf',
    size = 10MB,
    MAXSIZE = UNLIMITED,
    filegrowth=5MB
    )
GO
--endregion

--region 二、建表
USE bookStoreDB

--会员信息：（会员账号，姓名，手机号，余额，冻结余额）
--进货订单：（进货单号，书籍号码，进货数量，单价）
--销售清单：（日期，书籍号码，销售金额）
--书籍信息：（书籍号码，书名，类别，作者，书籍照片，照片格式，库存数量, 全新数量）
--充值记录：（充值单号,日期，会员账号，充值金额）
--赔偿记录：（书籍号码，会员账号，赔偿金额，赔偿日期）
--租借记录：（租借号，会员账号，书籍号码，租借日期，是否续租，是否归还，应还日期）

--1.建会员表
CREATE TABLE memberData(
    memberID char(8) PRIMARY KEY,
    memberName nvarchar(10) Not NULL,
    memberPhoneNumber char(11) UNIQUE,
    memberOverage money DEFAULT 0,
    memberFreezeOverage money DEFAULT 0
)

--2.建进货表
CREATE TABLE Purchase(
    PurchaseID char(6),
    BookISBN char(13) FOREIGN KEY REFERENCES BookData(BookISBN),
    Amount int NOT NULL,
    BookPrice money NOT NULL,
    PurchaseData DateTime NOT NULL DEFAULT GETDATE(),
    PRIMARY KEY (PurchaseID, BookISBN)
)

--3.建销售表
CREATE TABLE Sell(
    SellDate DateTime NOT NULL DEFAULT GETDATE(),
    BookISBN char(13) Not NULL FOREIGN KEY REFERENCES BookData(BookISBN),
    SellPrice money NOT NULL
)

--4.建书籍表
CREATE TABLE BookData(
    BookISBN char(13) PRIMARY KEY,
    BookName nvarchar(25) NOT NULL,
    BookAuthor nvarchar(15) NOT NULL,
    BookCategory nvarchar(10),
    BookPicture image,
    PictureFormat nvarchar(5),
    BookNum int NOT NULL,
    BrandNewBookNum int NOT NULL
)

--5.建充值表
CREATE TABLE Recharge(
    RechargeID char(10) PRIMARY KEY,
    RechargeDate DateTime NOT NULL DEFAULT GETDATE(),
    memberID char(8) NOT NULL FOREIGN KEY REFERENCES memberData(memberID),
    RechargeMoney money NOT NULL
)

--6.建赔偿表
CREATE TABLE Compensate(
    BookISBN char(13) NOT NULL FOREIGN KEY REFERENCES BookData(BookISBN),
    memberID char(8) NOT NULL FOREIGN KEY REFERENCES memberData(memberID),
    CompensateMoney money NOT NULL,
    CompensateData DateTime NOT NULL DEFAULT GETDATE(),
)

--7.建租借表
CREATE TABLE Lease(
    LeaseID char(10) PRIMARY KEY,
    memberID char(8) FOREIGN KEY REFERENCES memberData(memberID),
    BookISBN char(13) Foreign KEY REFERENCES BookData(BookISBN),
    LeaseData DateTime NOT NULL DEFAULT GETDATE(),
    WhetherLeaseRenew nchar(1) CHECK(WhetherLeaseRenew in (N'是', N'否')),
    WhetherReturn nchar(1) CHECK(WhetherReturn in (N'是', N'否')),
    DueDate DateTime NOT NULL DEFAULT DATEADD(day,30,GETDATE())
)
--endregion

--region 三、创建视图

-- 会员拓展视图(会员账号、总充值金额、现租借图书数量)
-- 逾期未归还图书视图(姓名、手机号、书籍名、应还日期)
-- 库存过少书籍(书籍号码、书名、库存数量、全新数量)
-- 本月销售清单(日期、书籍号码、书名、类别、销售金额)
-- 进货简化视图(进货单号、进货总数量、进货日期、进货总价)
-- 未归还图书视图

--region 1.会员拓展视图
create view memberView as
    select A.memberID, AllRechargeMoney, BorrowingBook
    from (select memberData.memberID, sum(RechargeMoney) AllRechargeMoney from memberData, Recharge where memberData.memberID = Recharge.memberID group by memberData.memberID) as A,
         (select memberData.memberID, count(LeaseID) BorrowingBook from memberData, Lease where memberData.memberID = Lease.memberID and Lease.WhetherReturn = N'否' group by memberData.memberID) as B
    where A.memberID = B.memberID
--endregion

--region 2.逾期未归还图书视图
create view OverdueBook as
    select LeaseID,memberName,memberPhoneNumber,BookName,LeaseData,WhetherLeaseRenew,DueDate
    from memberData,Lease,BookData
    where memberData.memberID = Lease.memberID
    and Lease.BookISBN = BookData.BookISBN
    and 0>DATEDIFF(day,GETDATE(), Lease.DueDate)
--endregion

--region 3.库存过少图书
create view LowInventory as
    select BookISBN, BookName, BookNum,BrandNewBookNum
    from BookData
    where BookNum<10
    or BrandNewBookNum<5
--endregion

---region 4.本月销售清单
create view ThisMonthSSalesList as
    select SellDate,BookData.BookISBN,BookData.BookName,BookData.BookCategory,SellPrice
    from Sell,BookData
    where Sell.BookISBN = BookData.BookISBN
    and DATEDIFF(month,GETDATE(), Sell.SellDate)=0
--endregion

--region 5.进货简化视图
create view PurchaseView as
    select PurchaseID,sum(Amount) sumCount,PurchaseData,sum(Amount*BookPrice) sumMoney
    from Purchase
    group by Purchase.PurchaseID, PurchaseData
--endregion

--region 6.未归还图书视图
create view LeaseView as
    select LeaseID,memberName,memberPhoneNumber,BookName,LeaseData,WhetherLeaseRenew,DueDate
    from Lease, memberData, BookData
    where WhetherReturn=N'否'
    and memberData.memberID = Lease.memberID
    and Lease.BookISBN=BookData.BookISBN
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
on Compensate(BookISBN)
--endregion

--region 9.租借记录会员账号添加索引
create Index LeaseMemberIDIndex
on Lease(memberID)
--endregion

--region 10.租借记录书籍号码添加索引
create Index LeaseBookISBNIndex
on Lease(BookISBN)
--endregion

--endregion

--region 五、创建触发器、存储过程、函数

-- 触发器：审核、数据同步功能，当写入某个数据时检查数据是否合理，是否与其他数据冲突、且同步其他表中数据
-- 存储过程：对某些功能进行封装， 避免了程序和数据库通信时传输大量代码
-- 函数：必须有返回值、用来拓展标准SQL语句，可以嵌入SQL语句中


--endregion