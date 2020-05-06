create database [webapi_database]
GO
USE [webapi_database]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 3/8/2020 5:41:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[id] [int] IDENTITY(100,1) NOT NULL,
	[name] [varchar](50) NULL,
	[salary] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[employee] ON 
GO
INSERT [dbo].[employee] ([id], [name], [salary]) VALUES (100, N'Punita', 50000)
GO
INSERT [dbo].[employee] ([id], [name], [salary]) VALUES (101, N'Priya', 60000)
GO
INSERT [dbo].[employee] ([id], [name], [salary]) VALUES (102, N'Pooja', 60000)
GO
INSERT [dbo].[employee] ([id], [name], [salary]) VALUES (103, N'Priyanshi', 40000)
GO
INSERT [dbo].[employee] ([id], [name], [salary]) VALUES (104, N'Priyanka', 30000)
GO
SET IDENTITY_INSERT [dbo].[employee] OFF
GO
