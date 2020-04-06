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
--赔偿记录：（书籍号码，会员账号，赔偿金额）
--租借记录：（租借号，会员账号，书籍号码，租借日期，是否续租）

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
    SellData DateTime NOT NULL DEFAULT GETDATE(),
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
    WhetherLeaseRenew nchar(1) CHECK(WhetherLeaseRenew in (N'是', N'否'))
)
--endregion

--region 三、创建视图、添加索引

--region 1.视图
-- 会员拓展视图(会员账号、总充值金额、现租借图书数量)
-- 逾期未归还图书视图(姓名、手机号、书籍名、应还日期)
-- 库存过少书籍(书记账号、书名、库存数量、全新数量)
-- 本月销售清单(日期、书籍号码、销售金额)



--endregion

--region 2.索引

--endregion

--endregion


--region 四、创建触发器、存储过程、函数


--endregion