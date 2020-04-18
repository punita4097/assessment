USE [master]
GO
/****** Object:  Database [BlazorDB]    Script Date: 4/13/2020 12:11:35 PM ******/
CREATE DATABASE [BlazorDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BlazorDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BlazorDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BlazorDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BlazorDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BlazorDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BlazorDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BlazorDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BlazorDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BlazorDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BlazorDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BlazorDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [BlazorDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BlazorDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BlazorDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BlazorDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BlazorDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BlazorDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BlazorDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BlazorDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BlazorDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BlazorDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BlazorDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BlazorDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BlazorDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BlazorDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BlazorDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BlazorDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [BlazorDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BlazorDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BlazorDB] SET  MULTI_USER 
GO
ALTER DATABASE [BlazorDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BlazorDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BlazorDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BlazorDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BlazorDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BlazorDB] SET QUERY_STORE = OFF
GO
USE [BlazorDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 4/13/2020 12:11:36 PM ******/
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
/****** Object:  Table [dbo].[Logins]    Script Date: 4/13/2020 12:11:36 PM ******/
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
 CONSTRAINT [PK_Logins] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NavBar]    Script Date: 4/13/2020 12:11:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NavBar](
	[NavId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NOT NULL,
	[Reference] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_NavBar] PRIMARY KEY CLUSTERED 
(
	[NavId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 4/13/2020 12:11:36 PM ******/
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
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200409132706_InitialCommit', N'3.1.3')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200410173403_update', N'3.1.3')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200410175324_update1', N'3.1.3')
GO
SET IDENTITY_INSERT [dbo].[Logins] ON 
GO
INSERT [dbo].[Logins] ([Id], [Name], [Email], [Mobile], [Password]) VALUES (1, N'Punita', N'P@gmail.com', N'123456789', N'123')
GO
INSERT [dbo].[Logins] ([Id], [Name], [Email], [Mobile], [Password]) VALUES (2, N'Shagun', N's@gmail.com', N'345678', N'123')
GO
INSERT [dbo].[Logins] ([Id], [Name], [Email], [Mobile], [Password]) VALUES (3, N'Neha', N'n@gmail.com', N'9876543', N'123')
GO
INSERT [dbo].[Logins] ([Id], [Name], [Email], [Mobile], [Password]) VALUES (7, N'Abhishek', N'a@gmail.com', N'1243564774', N'123')
GO
SET IDENTITY_INSERT [dbo].[Logins] OFF
GO
SET IDENTITY_INSERT [dbo].[NavBar] ON 
GO
INSERT [dbo].[NavBar] ([NavId], [CategoryName], [Reference]) VALUES (1, N'Home', N'Index')
GO
INSERT [dbo].[NavBar] ([NavId], [CategoryName], [Reference]) VALUES (2, N'Counter', N'Counter')
GO
INSERT [dbo].[NavBar] ([NavId], [CategoryName], [Reference]) VALUES (3, N'FetchData', N'FetchData')
GO
INSERT [dbo].[NavBar] ([NavId], [CategoryName], [Reference]) VALUES (4, N'Student', N'Student')
GO
INSERT [dbo].[NavBar] ([NavId], [CategoryName], [Reference]) VALUES (8, N'entertainment', N'https://www.youtube.com/')
GO
SET IDENTITY_INSERT [dbo].[NavBar] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 
GO
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Address], [city], [Age]) VALUES (1, N'Punita', N'Yadav', N'Haryana', N'Faridabad', 23)
GO
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Address], [city], [Age]) VALUES (3, N'Sumit', N'Yadav', N'UttarPradesh', N'Ghazipur', 15)
GO
INSERT [dbo].[Students] ([StudentId], [FirstName], [LastName], [Address], [city], [Age]) VALUES (4, N'Pooja', N'Yadav', N'UK', N'GHJ', 12)
GO
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
ALTER TABLE [dbo].[NavBar] ADD  DEFAULT (N'') FOR [Reference]
GO
USE [master]
GO
ALTER DATABASE [BlazorDB] SET  READ_WRITE 
GO
