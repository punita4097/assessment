create database [Jwt_database]
GO
USE [Jwt_database]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 3/18/2020 9:52:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[id] [int] IDENTITY(100,1) NOT NULL,
	[name] [varchar](40) NULL,
	[Salary] [int] NULL,
	[Password] [text] NULL,
	[Role] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 3/18/2020 9:52:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[username] [varchar](20) NULL,
	[password] [varchar](20) NULL,
	[role] [varchar](20) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 
GO
INSERT [dbo].[Employee] ([id], [name], [Salary], [Password], [Role]) VALUES (100, N'Punita', 0, N'123', N'Admin')
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
INSERT [dbo].[login] ([username], [password], [role]) VALUES (N'Punita', N'123', N'admin')
GO
INSERT [dbo].[login] ([username], [password], [role]) VALUES (N'Shagun', N'123', N'user')
GO
select * from employee