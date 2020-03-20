create database [Transaction]
USE [Transaction]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 20-03-2020 20:10:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 20-03-2020 20:10:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustId] [int] IDENTITY(1,1) NOT NULL,
	[CustName] [nvarchar](max) NULL,
	[CustPhone] [bigint] NULL,
	[CustAddress] [nvarchar](max) NULL,
	[NoOfOrders] [int] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 20-03-2020 20:10:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[FkCustId] [int] NULL,
	[FkProdId] [int] NULL,
	[OrderAmount] [decimal](18, 2) NULL,
	[OrderDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 20-03-2020 20:10:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProdId] [int] IDENTITY(1,1) NOT NULL,
	[ProdName] [nvarchar](max) NULL,
	[ProdPrice] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProdId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200320140714_createTransaction', N'3.1.2')
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 
GO
INSERT [dbo].[Customers] ([CustId], [CustName], [CustPhone], [CustAddress], [NoOfOrders]) VALUES (3, N'Neha', 8743046792, N'Akshardham', 1)
GO
INSERT [dbo].[Customers] ([CustId], [CustName], [CustPhone], [CustAddress], [NoOfOrders]) VALUES (4, N'Ankit', 8800623668, N'Tri Nagar', 2)
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 
GO
INSERT [dbo].[Orders] ([OrderId], [FkCustId], [FkProdId], [OrderAmount], [OrderDate]) VALUES (1, 3, 1, CAST(500.00 AS Decimal(18, 2)), CAST(N'2020-03-19T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Orders] ([OrderId], [FkCustId], [FkProdId], [OrderAmount], [OrderDate]) VALUES (2, 4, 2, CAST(500.00 AS Decimal(18, 2)), CAST(N'2020-03-19T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Orders] ([OrderId], [FkCustId], [FkProdId], [OrderAmount], [OrderDate]) VALUES (3, 4, 1, CAST(500.00 AS Decimal(18, 2)), CAST(N'2020-03-10T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([ProdId], [ProdName], [ProdPrice]) VALUES (1, N'Phone Cover', CAST(500.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Products] ([ProdId], [ProdName], [ProdPrice]) VALUES (2, N'Sunglasses', CAST(500.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
/****** Object:  Index [IX_Orders_FkCustId]    Script Date: 20-03-2020 20:10:33 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_FkCustId] ON [dbo].[Orders]
(
	[FkCustId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_FkProdId]    Script Date: 20-03-2020 20:10:33 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_FkProdId] ON [dbo].[Orders]
(
	[FkProdId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers_FkCustId] FOREIGN KEY([FkCustId])
REFERENCES [dbo].[Customers] ([CustId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers_FkCustId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Products_FkProdId] FOREIGN KEY([FkProdId])
REFERENCES [dbo].[Products] ([ProdId])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Products_FkProdId]
GO

