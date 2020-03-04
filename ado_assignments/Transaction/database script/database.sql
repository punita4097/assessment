create database [ado_assignment]
GO
USE [ado_assignment]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 3/3/2020 10:01:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Account_number] [int] NULL,
	[Customer_name] [varchar](50) NULL,
	[Balance] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[department]    Script Date: 3/3/2020 10:01:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[department](
	[d_id] [int] NULL,
	[d_name] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 3/3/2020 10:01:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[id] [int] NULL,
	[name] [varchar](50) NULL,
	[address] [varchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Customer] ([Account_number], [Customer_name], [Balance]) VALUES (1001, N'Punita', 10000)
GO
INSERT [dbo].[Customer] ([Account_number], [Customer_name], [Balance]) VALUES (1002, N'Pooja', 10000)
GO
INSERT [dbo].[department] ([d_id], [d_name]) VALUES (1, N'cs')
GO
INSERT [dbo].[department] ([d_id], [d_name]) VALUES (2, N'IT')
GO
INSERT [dbo].[employee] ([id], [name], [address]) VALUES (1, N'punita', N'fbd')
GO
INSERT [dbo].[employee] ([id], [name], [address]) VALUES (2, N'priya', N'noida')
GO
INSERT [dbo].[employee] ([id], [name], [address]) VALUES (3, N'pooja', N'delhi')
GO
/****** Object:  StoredProcedure [dbo].[employeedetails]    Script Date: 3/3/2020 10:01:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[employeedetails] @id int,@name varchar(50)

as


select * from employee

where id=@id and name=@name
GO
USE [master]
GO
ALTER DATABASE [ado_assignment] SET  READ_WRITE 
GO
