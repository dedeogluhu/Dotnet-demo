﻿USE [master]
GO
/****** Object:  Database [OnlineShopping]    Script Date: 10.08.2020 15:20:52 ******/
CREATE DATABASE [OnlineShopping]
GO
ALTER DATABASE [OnlineShopping] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OnlineShopping].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OnlineShopping] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OnlineShopping] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OnlineShopping] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OnlineShopping] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OnlineShopping] SET ARITHABORT OFF 
GO
ALTER DATABASE [OnlineShopping] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OnlineShopping] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OnlineShopping] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OnlineShopping] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OnlineShopping] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OnlineShopping] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OnlineShopping] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OnlineShopping] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OnlineShopping] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OnlineShopping] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OnlineShopping] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OnlineShopping] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OnlineShopping] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OnlineShopping] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OnlineShopping] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OnlineShopping] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OnlineShopping] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OnlineShopping] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OnlineShopping] SET  MULTI_USER 
GO
ALTER DATABASE [OnlineShopping] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OnlineShopping] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OnlineShopping] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OnlineShopping] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OnlineShopping] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OnlineShopping] SET QUERY_STORE = OFF
GO
USE [OnlineShopping]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [char](6) NOT NULL,
	[Password] [char](4) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Cash] [money] NOT NULL,
	[isActive] [bit] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Customers_CustomerId] UNIQUE NONCLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[isActive] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SellerId] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[SaleDate] [date] NOT NULL,
	[isActive] [bit] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[SellerId] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[StockAmount] [int] NOT NULL,
	[isActive] [bit] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sellers]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sellers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SellerId] [char](6) NOT NULL,
	[Password] [char](4) NOT NULL,
	[CompanyName] [nvarchar](50) NOT NULL,
	[Cash] [money] NOT NULL,
	[isActive] [bit] NOT NULL,
 CONSTRAINT [PK_Sellers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Sellers_SellerId] UNIQUE NONCLUSTERED 
(
	[SellerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [DF_Customers_isActive]  DEFAULT ((1)) FOR [isActive]
GO
ALTER TABLE [dbo].[OrderDetails] ADD  CONSTRAINT [DF_OrderDetails_isActive]  DEFAULT ((1)) FOR [isActive]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_SaleDate]  DEFAULT (getdate()) FOR [SaleDate]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF_Orders_isActive]  DEFAULT ((1)) FOR [isActive]
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_isActive]  DEFAULT ((1)) FOR [isActive]
GO
ALTER TABLE [dbo].[Sellers] ADD  CONSTRAINT [DF_Sellers_isActive]  DEFAULT ((1)) FOR [isActive]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Sellers] FOREIGN KEY([SellerId])
REFERENCES [dbo].[Sellers] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Sellers]
GO
/****** Object:  StoredProcedure [dbo].[prc_Customers_Delete]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prc_Customers_Delete]
@Id int
as
Delete from Customers where Id = @Id

GO
/****** Object:  StoredProcedure [dbo].[prc_Customers_Insert]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prc_Customers_Insert]
@CustomerId char(6),
@Password char(4),
@FirstName nvarchar(50),
@LastName nvarchar(50),
@Cash money
as
insert into Customers(CustomerId,Password,FirstName,LastName,Cash) 
values(@CustomerId,@Password,@FirstName,@LastName,@Cash)

GO
/****** Object:  StoredProcedure [dbo].[prc_Customers_Select]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prc_Customers_Select]
as
select * from Customers
where isActive = 1

GO
/****** Object:  StoredProcedure [dbo].[prc_Customers_Update]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[prc_Customers_Update]
@Id int,
@CustomerId char(6),
@Password char(4),
@FirstName nvarchar(50),
@LastName nvarchar(50),
@Cash money
as
Update Customers set CustomerId = @CustomerId,Password = @Password, FirstName = @FirstName,
LastName = @LastName, Cash = @Cash
where Id = @Id

GO
/****** Object:  StoredProcedure [dbo].[prc_OrderDetails_Delete]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[prc_OrderDetails_Delete]
@OrderId int,
@ProductId int
as
Delete from OrderDetails 
where OrderId = @OrderId and ProductId = @ProductId

GO
/****** Object:  StoredProcedure [dbo].[prc_OrderDetails_Insert]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[prc_OrderDetails_Insert]
@OrderId int,
@ProductId int,
@Price money,
@Quantity int
as
insert into OrderDetails(OrderId,ProductId,Price,Quantity)
values(@OrderId,@ProductId,@Price,@Quantity)

GO
/****** Object:  StoredProcedure [dbo].[prc_OrderDetails_Select]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[prc_OrderDetails_Select]
as
select * from OrderDetails
where isActive = 1

GO
/****** Object:  StoredProcedure [dbo].[prc_OrderDetails_Update]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[prc_OrderDetails_Update]
@OrderId int,
@ProductId int,
@Price money,
@Quantity int
as
Update OrderDetails set OrderId = @OrderId, ProductId = @ProductId, 
Price = @Price, Quantity = @Quantity
where OrderId = @OrderId and ProductId = @ProductId

GO
/****** Object:  StoredProcedure [dbo].[prc_Orders_Delete]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[prc_Orders_Delete]
@Id int
as
Delete from Orders
where Id = @Id

GO
/****** Object:  StoredProcedure [dbo].[prc_Orders_Insert]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[prc_Orders_Insert]
@SellerId int,
@CustomerId int,
@SaleDate date
as
insert into Orders(SellerId,CustomerId,SaleDate)
values(@SellerId,@CustomerId,@SaleDate)

GO
/****** Object:  StoredProcedure [dbo].[prc_Orders_Select]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[prc_Orders_Select]
as
select * from Orders
where isActive = 1

GO
/****** Object:  StoredProcedure [dbo].[prc_Orders_Update]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[prc_Orders_Update]
@Id int,
@SellerId int,
@CustomerId int,
@SaleDate date
as
Update Orders set SellerId = @SellerId, CustomerId = @CustomerId, SaleDate = @SaleDate
where Id = @Id

GO
/****** Object:  StoredProcedure [dbo].[prc_Products_Delete]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[prc_Products_Delete]
@Id int
as
Delete from Products
where Id = @Id

GO
/****** Object:  StoredProcedure [dbo].[prc_Products_Insert]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[prc_Products_Insert]
@ProductName nvarchar(50),
@SellerId int,
@UnitPrice money,
@StockAmount int
as
insert into Products(ProductName,SellerId,UnitPrice,StockAmount)
values(@ProductName,@SellerId,@UnitPrice,@StockAmount)

GO
/****** Object:  StoredProcedure [dbo].[prc_Products_Select]    Script Date: 10.08.2020 15:20:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[prc_Products_Select]
as
select * from Products
where isActive = 1

GO
/****** Object:  StoredProcedure [dbo].[prc_Products_Update]    Script Date: 10.08.2020 15:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[prc_Products_Update]
@Id int,
@ProductName nvarchar(50),
@SellerId int,
@UnitPrice money,
@StockAmount int
as
Update Products set ProductName = @ProductName, SellerId = @SellerId, UnitPrice = @UnitPrice, StockAmount = @StockAmount
where Id = @Id
GO
/****** Object:  StoredProcedure [dbo].[prc_Sellers_Delete]    Script Date: 10.08.2020 15:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[prc_Sellers_Delete]
@Id int
as
Delete from Sellers
where Id = @Id






GO
/****** Object:  StoredProcedure [dbo].[prc_Sellers_Insert]    Script Date: 10.08.2020 15:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[prc_Sellers_Insert]
@SellerId char(6),
@Password char(4),
@CompanyName nvarchar(50),
@Cash money
as
insert into Sellers(SellerId,Password,CompanyName,Cash)
values(@SellerId,@Password,@CompanyName,@Cash)























GO
/****** Object:  StoredProcedure [dbo].[prc_Sellers_Select]    Script Date: 10.08.2020 15:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[prc_Sellers_Select]
as
select * from Sellers
where isActive = 1

GO
/****** Object:  StoredProcedure [dbo].[prc_Sellers_Update]    Script Date: 10.08.2020 15:20:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[prc_Sellers_Update]
@Id int,
@SellerId char(6),
@Password char(4),
@CompanyName nvarchar(50),
@Cash money
as
Update Sellers set SellerId = @SellerId, Password = @Password, CompanyName = @CompanyName,
Cash = @Cash
where Id = @Id









GO
USE [master]
GO
ALTER DATABASE [OnlineShopping] SET  READ_WRITE 
GO
