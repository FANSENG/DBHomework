USE [master]
GO
/****** Object:  Database [bookStoreDB]    Script Date: 2020/4/12 18:40:30 ******/
CREATE DATABASE [bookStoreDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bookStoreDB_data', FILENAME = N'D:\Projects\SQLServer\bookStoreDB\bookStoreDB_data.mdf' , SIZE = 10240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 5120KB )
 LOG ON 
( NAME = N'bookStoreDB_log', FILENAME = N'D:\Projects\SQLServer\bookStoreDB\bookStoreDB_log.ldf' , SIZE = 10240KB , MAXSIZE = 2048GB , FILEGROWTH = 5120KB )
GO
ALTER DATABASE [bookStoreDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bookStoreDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bookStoreDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bookStoreDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bookStoreDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bookStoreDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bookStoreDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [bookStoreDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bookStoreDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bookStoreDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bookStoreDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bookStoreDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bookStoreDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bookStoreDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bookStoreDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bookStoreDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bookStoreDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [bookStoreDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bookStoreDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bookStoreDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bookStoreDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bookStoreDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bookStoreDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bookStoreDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bookStoreDB] SET RECOVERY FULL 
GO
ALTER DATABASE [bookStoreDB] SET  MULTI_USER 
GO
ALTER DATABASE [bookStoreDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bookStoreDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bookStoreDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bookStoreDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bookStoreDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'bookStoreDB', N'ON'
GO
ALTER DATABASE [bookStoreDB] SET QUERY_STORE = OFF
GO
USE [bookStoreDB]
GO
/****** Object:  UserDefinedFunction [dbo].[getAllMembersNum]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Function [dbo].[getAllMembersNum]()
returns int
as
    begin
        declare @count int
        select @count = count(*) from memberData
        return @count
    end
GO
/****** Object:  UserDefinedFunction [dbo].[getThisMonthLeaseCount]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[getThisMonthLeaseCount]()
returns int
as
    begin
        declare @count int
        select @count = count(*) from Lease
        where DATEPART(year,Lease.LeaseDate) = DATEPART(year,GETDATE())
        and DATEPART(month,Lease.LeaseDate) = DATEPART(month,GETDATE())
        return @count
    end
GO
/****** Object:  UserDefinedFunction [dbo].[getYearRechargeCount]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[getYearRechargeCount]()
returns int
as
    begin
        declare @count int
        select @count = count(*) from Recharge
        where DATEPART(year,Recharge.RechargeDate) = DATEPART(year,GETDATE())
        return @count
    end
GO
/****** Object:  Table [dbo].[memberData]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[memberData](
	[memberID] [char](8) NOT NULL,
	[memberName] [nvarchar](10) NOT NULL,
	[memberPhoneNumber] [char](11) NULL,
	[memberOverage] [money] NULL,
	[memberFreezeOverage] [money] NULL,
	[memberState] [nvarchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[memberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[memberPhoneNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recharge]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recharge](
	[RechargeID] [char](10) NOT NULL,
	[RechargeDate] [datetime] NOT NULL,
	[memberID] [char](8) NOT NULL,
	[RechargeMoney] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RechargeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lease]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lease](
	[LeaseID] [char](10) NOT NULL,
	[memberID] [char](8) NULL,
	[BookISBN] [char](13) NULL,
	[LeaseDate] [datetime] NOT NULL,
	[WhetherLeaseRenew] [nchar](1) NULL,
	[WhetherReturn] [nchar](1) NULL,
	[DueDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LeaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[memberView]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[memberView] as
    select A.memberID, AllRechargeMoney, BorrowingBook
    from (select memberData.memberID, sum(RechargeMoney) AllRechargeMoney from memberData, Recharge where memberData.memberID = Recharge.memberID and memberData.memberState=N'正常' group by memberData.memberID) as A,
         (select memberData.memberID, count(LeaseID) BorrowingBook from memberData, Lease where memberData.memberID = Lease.memberID and Lease.WhetherReturn = N'否' group by memberData.memberID) as B
    where A.memberID = B.memberID
GO
/****** Object:  Table [dbo].[BookData]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookData](
	[BookISBN] [char](13) NOT NULL,
	[BookName] [nvarchar](25) NOT NULL,
	[BookAuthor] [nvarchar](15) NOT NULL,
	[BookCategory] [nvarchar](10) NULL,
	[BookPicture] [image] NULL,
	[PictureFormat] [nvarchar](5) NULL,
	[BookNum] [int] NOT NULL,
	[BrandNewBookNum] [int] NOT NULL,
	[BookPrice] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BookISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[OverdueBook]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[OverdueBook] as
    select LeaseID,memberName,memberPhoneNumber,BookName,LeaseDate,WhetherLeaseRenew,DueDate
    from memberData,Lease,BookData
    where memberData.memberID = Lease.memberID
    and Lease.BookISBN = BookData.BookISBN
    and 0>DATEDIFF(day,GETDATE(), Lease.DueDate)
    and memberData.memberState=N'正常'
GO
/****** Object:  View [dbo].[LowInventory]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[LowInventory] as
    select BookISBN, BookName, BookNum,BrandNewBookNum
    from BookData
    where BookNum<10
    or BrandNewBookNum<5
GO
/****** Object:  Table [dbo].[Sell]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sell](
	[SellDate] [datetime] NOT NULL,
	[BookISBN] [char](13) NOT NULL,
	[SellNum] [int] NOT NULL,
	[SellPrice] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ThisMonthSSalesList]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ThisMonthSSalesList] as
    select SellDate,BookData.BookISBN,BookData.BookName,BookData.BookCategory,SellPrice
    from Sell,BookData
    where Sell.BookISBN = BookData.BookISBN
    and DATEDIFF(month,GETDATE(), Sell.SellDate)=0
GO
/****** Object:  Table [dbo].[Purchase]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchase](
	[PurchaseID] [char](6) NOT NULL,
	[BookISBN] [char](13) NOT NULL,
	[Amount] [int] NOT NULL,
	[BookPrice] [money] NOT NULL,
	[PurchaseDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PurchaseID] ASC,
	[BookISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[PurchaseView]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[PurchaseView] as
    select PurchaseID,sum(Amount) sumCount,PurchaseDate,sum(Amount*BookPrice) sumMoney
    from Purchase
    group by Purchase.PurchaseID, PurchaseDate
GO
/****** Object:  View [dbo].[LeaseView]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[LeaseView] as
    select LeaseID,memberName,memberPhoneNumber,BookName,LeaseDate,WhetherLeaseRenew,DueDate
    from Lease, memberData, BookData
    where WhetherReturn=N'否'
    and memberData.memberID = Lease.memberID
    and Lease.BookISBN=BookData.BookISBN
GO
/****** Object:  View [dbo].[BookView]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[BookView] as
    select A.BookISBN, A.BookName,A.BookCategory,A.BookAuthor,A.BookNum,A.BrandNewBookNum,A.BookPrice,A.SellCount,B.LeaseCount
    from (select BookData.BookISBN, BookData.BookName,BookData.BookCategory,BookData.BookAuthor,BookData.BookNum,BookData.BrandNewBookNum,BookData.BookPrice,sum(Sell.SellNum) SellCount from BookData,Sell where BookData.BookISBN = Sell.BookISBN group by BookData.BookISBN,BookName,BookNum,BookCategory,BookAuthor,BrandNewBookNum,BookPrice) A,
         (select BookData.BookISBN,count(*) LeaseCount from BookData,Lease where BookData.BookISBN=Lease.BookISBN group by BookData.BookISBN) B
    where A.BookISBN=B.BookISBN
GO
/****** Object:  View [dbo].[SellView]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[SellView] as
    select SellDate,BookData.BookISBN,BookData.BookName,BookData.BookCategory,SellNum,SellPrice
    from Sell,BookData
    where Sell.BookISBN = BookData.BookISBN
GO
/****** Object:  Table [dbo].[Compensate]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compensate](
	[BookISBN] [char](13) NOT NULL,
	[memberID] [char](8) NOT NULL,
	[CompensateMoney] [money] NOT NULL,
	[CompensateData] [datetime] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [BookAuthorIndex]    Script Date: 2020/4/12 18:40:30 ******/
CREATE NONCLUSTERED INDEX [BookAuthorIndex] ON [dbo].[BookData]
(
	[BookAuthor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [BookNameIndex]    Script Date: 2020/4/12 18:40:30 ******/
CREATE NONCLUSTERED INDEX [BookNameIndex] ON [dbo].[BookData]
(
	[BookName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [CompensateBookISBNIndex]    Script Date: 2020/4/12 18:40:30 ******/
CREATE NONCLUSTERED INDEX [CompensateBookISBNIndex] ON [dbo].[Compensate]
(
	[BookISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [CompensateMemberIdIndex]    Script Date: 2020/4/12 18:40:30 ******/
CREATE NONCLUSTERED INDEX [CompensateMemberIdIndex] ON [dbo].[Compensate]
(
	[memberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [LeaseBookISBNIndex]    Script Date: 2020/4/12 18:40:30 ******/
CREATE NONCLUSTERED INDEX [LeaseBookISBNIndex] ON [dbo].[Lease]
(
	[BookISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [LeaseMemberIDIndex]    Script Date: 2020/4/12 18:40:30 ******/
CREATE NONCLUSTERED INDEX [LeaseMemberIDIndex] ON [dbo].[Lease]
(
	[memberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PhoneNumberIndex]    Script Date: 2020/4/12 18:40:30 ******/
CREATE UNIQUE NONCLUSTERED INDEX [PhoneNumberIndex] ON [dbo].[memberData]
(
	[memberPhoneNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [PurchaseIndex]    Script Date: 2020/4/12 18:40:30 ******/
CREATE NONCLUSTERED INDEX [PurchaseIndex] ON [dbo].[Purchase]
(
	[BookISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RechargeMemberIDIndex]    Script Date: 2020/4/12 18:40:30 ******/
CREATE NONCLUSTERED INDEX [RechargeMemberIDIndex] ON [dbo].[Recharge]
(
	[memberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [SellIndex]    Script Date: 2020/4/12 18:40:30 ******/
CREATE NONCLUSTERED INDEX [SellIndex] ON [dbo].[Sell]
(
	[BookISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Compensate] ADD  DEFAULT (getdate()) FOR [CompensateData]
GO
ALTER TABLE [dbo].[Lease] ADD  DEFAULT (getdate()) FOR [LeaseDate]
GO
ALTER TABLE [dbo].[Lease] ADD  DEFAULT (dateadd(day,(30),getdate())) FOR [DueDate]
GO
ALTER TABLE [dbo].[memberData] ADD  DEFAULT ((0)) FOR [memberOverage]
GO
ALTER TABLE [dbo].[memberData] ADD  DEFAULT ((0)) FOR [memberFreezeOverage]
GO
ALTER TABLE [dbo].[Purchase] ADD  DEFAULT (getdate()) FOR [PurchaseDate]
GO
ALTER TABLE [dbo].[Recharge] ADD  DEFAULT (getdate()) FOR [RechargeDate]
GO
ALTER TABLE [dbo].[Sell] ADD  DEFAULT (getdate()) FOR [SellDate]
GO
ALTER TABLE [dbo].[Sell] ADD  DEFAULT ((1)) FOR [SellNum]
GO
ALTER TABLE [dbo].[Compensate]  WITH CHECK ADD FOREIGN KEY([BookISBN])
REFERENCES [dbo].[BookData] ([BookISBN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Compensate]  WITH CHECK ADD FOREIGN KEY([memberID])
REFERENCES [dbo].[memberData] ([memberID])
GO
ALTER TABLE [dbo].[Lease]  WITH CHECK ADD FOREIGN KEY([BookISBN])
REFERENCES [dbo].[BookData] ([BookISBN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Lease]  WITH CHECK ADD FOREIGN KEY([memberID])
REFERENCES [dbo].[memberData] ([memberID])
GO
ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD FOREIGN KEY([BookISBN])
REFERENCES [dbo].[BookData] ([BookISBN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Recharge]  WITH CHECK ADD FOREIGN KEY([memberID])
REFERENCES [dbo].[memberData] ([memberID])
GO
ALTER TABLE [dbo].[Sell]  WITH CHECK ADD FOREIGN KEY([BookISBN])
REFERENCES [dbo].[BookData] ([BookISBN])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Lease]  WITH CHECK ADD CHECK  (([WhetherLeaseRenew]=N'否' OR [WhetherLeaseRenew]=N'是'))
GO
ALTER TABLE [dbo].[Lease]  WITH CHECK ADD CHECK  (([WhetherReturn]=N'否' OR [WhetherReturn]=N'是'))
GO
ALTER TABLE [dbo].[memberData]  WITH CHECK ADD CHECK  (([memberState]=N'注销' OR [memberState]=N'正常'))
GO
/****** Object:  StoredProcedure [dbo].[getBookDataByAuthor]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getBookDataByAuthor]
    @Author nvarchar(15)
as
    begin
        select *
        from BookView
        where BookAuthor like '%'+@Author+'%'
    end
GO
/****** Object:  StoredProcedure [dbo].[getBookDataByAuthorAndCategory]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getBookDataByAuthorAndCategory]
    @Author nvarchar(15),
    @Category nvarchar(10)
as
    begin
        select *
        from BookView
        where BookAuthor like '%'+@Author+'%'
        and BookCategory = @Category
    end
GO
/****** Object:  StoredProcedure [dbo].[getBookDataByBookName]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getBookDataByBookName]
    @BookName nvarchar(25)
as
    begin
        select *
        from BookView
        where BookName like '%'+@BookName+'%'
    end
GO
/****** Object:  StoredProcedure [dbo].[getBookDataByBookName_AuthorAndCategory]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getBookDataByBookName_AuthorAndCategory]
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
GO
/****** Object:  StoredProcedure [dbo].[getBookDataByBookNameAndAuthor]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getBookDataByBookNameAndAuthor]
    @BookName nvarchar(25),
    @Author nvarchar(15)
as
    begin
        select *
        from BookView
        where BookName like '%'+@BookName+'%'
        or @Author like '%'+@Author+'%'
    end
GO
/****** Object:  StoredProcedure [dbo].[getBookDataByBookNameAndCategory]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getBookDataByBookNameAndCategory]
    @BookName nvarchar(25),
    @Category nvarchar(10)
as
    begin
        select *
        from BookView
        where BookName like '%'+@BookName+'%'
        and BookCategory = @Category
    end
GO
/****** Object:  StoredProcedure [dbo].[getBookDataByCategory]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getBookDataByCategory]
    @Category nvarchar(10)
as
    begin
        select *
        from BookView
        where BookCategory = @Category
    end
GO
/****** Object:  StoredProcedure [dbo].[getBookSellDataByBookISBN]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getBookSellDataByBookISBN]
    @BookISBN varchar(13)
as
    begin
        select *
        from BookView
        where BookISBN like '%'+@BookISBN+'%'
    end
GO
/****** Object:  StoredProcedure [dbo].[getCompensateDataByMemberID]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getCompensateDataByMemberID]
    @memberID varchar(8)
as
    begin
        select memberData.memberID,memberName,memberPhoneNumber,BookData.BookISBN,BookName
        from Compensate,memberData,BookData
        where memberData.memberID = Compensate.memberID
        and BookData.BookISBN = Compensate.BookISBN
        and memberData.memberPhoneNumber like '%'+@memberID+'%'
    end
GO
/****** Object:  StoredProcedure [dbo].[getCompensateDataByPhoneNumber]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getCompensateDataByPhoneNumber]
    @phoneNumber char(11)
as
    begin
        select memberData.memberID,memberName,memberPhoneNumber,BookData.BookISBN,BookName
        from Compensate,memberData,BookData
        where memberData.memberID = Compensate.memberID
        and BookData.BookISBN = Compensate.BookISBN
        and memberData.memberPhoneNumber = @phoneNumber
    end
GO
/****** Object:  StoredProcedure [dbo].[getLeaseDataByMemberID]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getLeaseDataByMemberID]
    @memberID varchar(8)
as
    begin
        select memberData.memberID,memberName,memberPhoneNumber,BookData.BookISBN,BookName
        from memberData,Lease,BookData
        where memberData.memberID= Lease.memberID
        and Lease.BookISBN = BookData.BookISBN
        and memberData.memberID like '%'+@memberID+'%'
    end
GO
/****** Object:  StoredProcedure [dbo].[getLeaseDataByPhoneNumber]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getLeaseDataByPhoneNumber]
    @PhoneNumber char(11)
as
    begin
        select memberData.memberID,memberName,memberPhoneNumber,BookData.BookISBN,BookName
        from memberData,Lease,BookData
        where memberData.memberID= Lease.memberID
        and Lease.BookISBN = BookData.BookISBN
        and memberData.memberPhoneNumber = @phoneNumber
    end
GO
/****** Object:  StoredProcedure [dbo].[getMemberDataByMemberID]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getMemberDataByMemberID]
    @memberID varchar(8)
as
    begin
        select *
        from memberData
        where memberID like '%'+@memberID+'%'
    end
GO
/****** Object:  StoredProcedure [dbo].[getMemberDataByMemberName]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getMemberDataByMemberName]
    @memberName nvarchar(10)
as
    begin
        select *
        from memberData
        where memberName like '%'+@memberName+'%'
    end
GO
/****** Object:  StoredProcedure [dbo].[getMemberDataByPhoneNumber]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getMemberDataByPhoneNumber]
    @phoneNumber char(11)
as
    begin
        select *
        from memberData
        where memberPhoneNumber = @phoneNumber
    end
GO
/****** Object:  StoredProcedure [dbo].[getPartTimePurchaseData]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getPartTimePurchaseData]
    @beginTime DateTime,
    @endTime DateTime = NULL
as
    begin
        if @endTime is NULL
            set @endTime = GETDATE()
        select PurchaseID,PurchaseDate,BookData.BookISBN,BookName,Purchase.BookPrice,Purchase.Amount
        from Purchase,BookData
        where BookData.BookISBN = Purchase.BookISBN
        and DATEDIFF(day,@beginTime,PurchaseDate)>0
        and DATEDIFF(day,PurchaseDate,@endTime)>0
    end
GO
/****** Object:  StoredProcedure [dbo].[getPartTimeSellData]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getPartTimeSellData]
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
GO
/****** Object:  StoredProcedure [dbo].[getPurchaseDataByPurchaseId]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getPurchaseDataByPurchaseId]
    @PurchaseID varchar(6)
as
    begin
        select PurchaseID,PurchaseDate,BookData.BookISBN,BookName,Purchase.BookPrice,Purchase.Amount
        from Purchase,BookData
        where BookData.BookISBN = Purchase.BookISBN
        and PurchaseID like '%'+@PurchaseID+'%'
    end
GO
/****** Object:  StoredProcedure [dbo].[getRechargeDataByMemberID]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getRechargeDataByMemberID]
    @memberID varchar(11)
as
    begin
        select memberData.memberID,memberName,memberPhoneNumber,RechargeID,RechargeDate,RechargeMoney
        from Recharge,memberData
        where memberData.memberID = Recharge.memberID
        and memberData.memberID like '%'+@memberID+'%'
    end
GO
/****** Object:  StoredProcedure [dbo].[getRechargeDataByPhoneNumber]    Script Date: 2020/4/12 18:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getRechargeDataByPhoneNumber]
    @phoneNumber char(11)
as
    begin
        select memberData.memberID,memberName,memberPhoneNumber,RechargeID,RechargeDate,RechargeMoney
        from Recharge,memberData
        where memberData.memberID = Recharge.memberID
        and memberPhoneNumber = @phoneNumber
    end
GO
USE [master]
GO
ALTER DATABASE [bookStoreDB] SET  READ_WRITE 
GO
