
CREATE DATABASE [ado_assignment]
GO

USE [ado_assignment]
GO
/****** Object:  Table [dbo].[department]    Script Date: 3/2/2020 3:18:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[department](
	[d_id] [int] NULL,
	[d_name] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 3/2/2020 3:18:49 PM ******/
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
INSERT [dbo].[employee] ([id], [name], [address]) VALUES (10, N'sanjay', N'Dehradun')
GO
INSERT [dbo].[employee] ([id], [name], [address]) VALUES (10, N'sanjay', N'Dehradun')
GO
/****** Object:  StoredProcedure [dbo].[employeedetails]    Script Date: 3/2/2020 3:18:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[employeedetails] @id int,@name varchar(50)

as


select * from employee

where id=@id and name=@name
GO
