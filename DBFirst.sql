create database Sales
USE [Sales]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 20-03-2020 20:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[cust_id] [int] IDENTITY(1000,2) NOT NULL,
	[cust_name] [varchar](50) NULL,
	[cust_phone] [bigint] NULL,
	[cust_address] [varchar](100) NULL,
	[NoOfOrders] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cust_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 20-03-2020 20:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[order_id] [int] IDENTITY(10,1) NOT NULL,
	[FK_cust_id] [int] NULL,
	[FK_prod_id] [int] NULL,
	[order_amount] [decimal](18, 0) NULL,
	[order_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 20-03-2020 20:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[prod_id] [int] IDENTITY(100,1) NOT NULL,
	[prod_name] [varchar](50) NULL,
	[prod_price] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[prod_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 
GO
INSERT [dbo].[Customer] ([cust_id], [cust_name], [cust_phone], [cust_address], [NoOfOrders]) VALUES (1000, N'Neha', 8743046792, N'East Delhi', 2)
GO
INSERT [dbo].[Customer] ([cust_id], [cust_name], [cust_phone], [cust_address], [NoOfOrders]) VALUES (1002, N'Ankit', 8800623668, N'West Delhi', 1)
GO
INSERT [dbo].[Customer] ([cust_id], [cust_name], [cust_phone], [cust_address], [NoOfOrders]) VALUES (1004, N'Shivam', 9560497385, N'Delhi', 2)
GO
INSERT [dbo].[Customer] ([cust_id], [cust_name], [cust_phone], [cust_address], [NoOfOrders]) VALUES (1006, N'Vijay', 8510037187, N'Aligarh', 1)
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 
GO
INSERT [dbo].[Orders] ([order_id], [FK_cust_id], [FK_prod_id], [order_amount], [order_date]) VALUES (10, 1000, 101, CAST(50000 AS Decimal(18, 0)), CAST(N'2020-03-10T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([order_id], [FK_cust_id], [FK_prod_id], [order_amount], [order_date]) VALUES (11, 1002, 102, CAST(20 AS Decimal(18, 0)), CAST(N'2020-03-18T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([order_id], [FK_cust_id], [FK_prod_id], [order_amount], [order_date]) VALUES (12, 1004, 100, CAST(500 AS Decimal(18, 0)), CAST(N'2020-02-29T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([order_id], [FK_cust_id], [FK_prod_id], [order_amount], [order_date]) VALUES (13, 1000, 103, CAST(250 AS Decimal(18, 0)), CAST(N'2020-03-18T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([order_id], [FK_cust_id], [FK_prod_id], [order_amount], [order_date]) VALUES (15, 1004, 101, CAST(50000 AS Decimal(18, 0)), CAST(N'2020-02-10T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Orders] ([order_id], [FK_cust_id], [FK_prod_id], [order_amount], [order_date]) VALUES (18, 1006, 101, CAST(50000 AS Decimal(18, 0)), CAST(N'2020-02-10T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([prod_id], [prod_name], [prod_price]) VALUES (100, N'Bag', CAST(500 AS Decimal(18, 0)))
GO
INSERT [dbo].[Products] ([prod_id], [prod_name], [prod_price]) VALUES (101, N'Laptop', CAST(50000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Products] ([prod_id], [prod_name], [prod_price]) VALUES (102, N'Pen', CAST(20 AS Decimal(18, 0)))
GO
INSERT [dbo].[Products] ([prod_id], [prod_name], [prod_price]) VALUES (103, N'Bottle', CAST(250 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([FK_cust_id])
REFERENCES [dbo].[Customer] ([cust_id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([FK_prod_id])
REFERENCES [dbo].[Products] ([prod_id])
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD CHECK  (([cust_phone]>=(6000000000.) AND [cust_phone]<=(9999999999.)))
GO
