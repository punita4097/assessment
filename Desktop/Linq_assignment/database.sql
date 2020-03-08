create database [linq_database]
GO
USE [linq_database]
GO
/****** Object:  Table [dbo].[address]    Script Date: 3/8/2020 5:00:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[address](
	[id] [int] NULL,
	[city] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 3/8/2020 5:00:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[id] [int] NULL,
	[name] [varchar](50) NULL,
	[salary] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ques9]    Script Date: 3/8/2020 5:00:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ques9](
	[id] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[address] ([id], [city]) VALUES (1, N'fbd')
GO
INSERT [dbo].[address] ([id], [city]) VALUES (2, N'delhi')
GO
INSERT [dbo].[address] ([id], [city]) VALUES (3, N'mumbai')
GO
INSERT [dbo].[address] ([id], [city]) VALUES (4, N'pune')
GO
INSERT [dbo].[address] ([id], [city]) VALUES (5, N'shimla')
GO
INSERT [dbo].[address] ([id], [city]) VALUES (6, N'dehradun')
GO
INSERT [dbo].[address] ([id], [city]) VALUES (7, N'dehradun')
GO
INSERT [dbo].[Person] ([id], [name], [salary]) VALUES (1, N'Punita', 600000)
GO
INSERT [dbo].[Person] ([id], [name], [salary]) VALUES (2, N'Shagun', 800000)
GO
INSERT [dbo].[Person] ([id], [name], [salary]) VALUES (3, N'Sonal', 700000)
GO
INSERT [dbo].[Person] ([id], [name], [salary]) VALUES (4, N'Latika', 900000)
GO
INSERT [dbo].[Person] ([id], [name], [salary]) VALUES (5, N'Neha', 500000)
GO
