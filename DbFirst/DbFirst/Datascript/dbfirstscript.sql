create database [SalesDb]
GO
USE [SalesDb]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 3/21/2020 12:11:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(100,1) NOT NULL,
	[CustomerName] [varchar](30) NULL,
	[City] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 3/21/2020 12:11:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderId] [int] IDENTITY(1000,1) NOT NULL,
	[Fk_ProductId] [int] NOT NULL,
	[Fk_CustomerId] [int] NOT NULL,
	[Quantity] [int] NULL,
	[OrderDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 3/21/2020 12:11:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 
GO
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [City]) VALUES (100, N'Punita', N'Faridabad')
GO
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [City]) VALUES (101, N'Sakshi', N'Noida')
GO
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [City]) VALUES (102, N'Shagun', N'Badarpur')
GO
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [City]) VALUES (103, N'Neha', N'Delhi')
GO
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [City]) VALUES (104, N'Sonal', N'Noida')
GO
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [City]) VALUES (105, N'Priya', N'Shimla')
GO
INSERT [dbo].[Customer] ([CustomerId], [CustomerName], [City]) VALUES (106, N'Vijay', N'Delhi')
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 
GO
INSERT [dbo].[Orders] ([OrderId], [Fk_ProductId], [Fk_CustomerId], [Quantity], [OrderDate]) VALUES (1000, 1, 100, 5, CAST(N'2020-03-19' AS Date))
GO
INSERT [dbo].[Orders] ([OrderId], [Fk_ProductId], [Fk_CustomerId], [Quantity], [OrderDate]) VALUES (1001, 2, 101, 4, CAST(N'2020-03-20' AS Date))
GO
INSERT [dbo].[Orders] ([OrderId], [Fk_ProductId], [Fk_CustomerId], [Quantity], [OrderDate]) VALUES (1002, 1, 104, 7, CAST(N'2020-03-12' AS Date))
GO
INSERT [dbo].[Orders] ([OrderId], [Fk_ProductId], [Fk_CustomerId], [Quantity], [OrderDate]) VALUES (1003, 3, 103, 1, CAST(N'2020-04-29' AS Date))
GO
INSERT [dbo].[Orders] ([OrderId], [Fk_ProductId], [Fk_CustomerId], [Quantity], [OrderDate]) VALUES (1004, 4, 100, 10, CAST(N'2020-04-19' AS Date))
GO
INSERT [dbo].[Orders] ([OrderId], [Fk_ProductId], [Fk_CustomerId], [Quantity], [OrderDate]) VALUES (1005, 6, 106, 2, CAST(N'2020-03-29' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 
GO
INSERT [dbo].[Product] ([ProductId], [ProductName]) VALUES (1, N'Bag')
GO
INSERT [dbo].[Product] ([ProductId], [ProductName]) VALUES (2, N'watch')
GO
INSERT [dbo].[Product] ([ProductId], [ProductName]) VALUES (3, N'Shirt')
GO
INSERT [dbo].[Product] ([ProductId], [ProductName]) VALUES (4, N'Band')
GO
INSERT [dbo].[Product] ([ProductId], [ProductName]) VALUES (5, N'Cap')
GO
INSERT [dbo].[Product] ([ProductId], [ProductName]) VALUES (6, N'Shirt')
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([Fk_CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([Fk_ProductId])
REFERENCES [dbo].[Product] ([ProductId])
GO

ALTER DATABASE [SalesDb] SET  READ_WRITE 
GO
