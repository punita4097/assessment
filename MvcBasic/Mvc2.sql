create database [RazorCrudDB]
GO
USE [RazorCrudDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 4/13/2020 4:33:56 PM ******/
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
/****** Object:  Table [dbo].[Logins]    Script Date: 4/13/2020 4:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logins](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Mobile] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Isadmin] [bit] NULL,
 CONSTRAINT [PK_Logins] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 4/13/2020 4:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NOT NULL,
	[city] [nvarchar](max) NOT NULL,
	[Age] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200409073625_InitialCommit', N'3.1.3')
GO
SET IDENTITY_INSERT [dbo].[Logins] ON 
GO
INSERT [dbo].[Logins] ([Id], [Name], [Email], [Mobile], [Password], [Isadmin]) VALUES (1, N'Punita', N'P@gmail.com', N'7689544443', N'123', 1)
GO
SET IDENTITY_INSERT [dbo].[Logins] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 
GO
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Address], [city], [Age]) VALUES (1, N'Shagun', N'Gupta', N'bdr', N'bg', 23)
GO
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Address], [city], [Age]) VALUES (2, N'Punita', N'yadav', N'fbd', N'fbd', 23)
GO
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Address], [city], [Age]) VALUES (3, N'neha', NULL, N'del', N'del', 23)
GO
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Address], [city], [Age]) VALUES (4, N'Sonal', NULL, N'asd', N'asd', 0)
GO
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Address], [city], [Age]) VALUES (5, N'Abhishek', NULL, N'sasd', N'sdds', 0)
GO
SET IDENTITY_INSERT [dbo].[Students] OFF
ALTER DATABASE [RazorCrudDB] SET  READ_WRITE 
GO
