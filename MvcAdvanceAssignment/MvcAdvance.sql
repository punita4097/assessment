create Database [MvcPrject]
GO
USE [MvcPrject]
GO
/****** Object:  Table [dbo].[Register]    Script Date: 4/19/2020 3:23:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Register](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](max) NOT NULL,
	[Mobile] [varchar](10) NOT NULL,
	[Password] [varchar](8) NOT NULL,
	[Isadmin] [bit] NULL,
 CONSTRAINT [PK_Register] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Register] ON 
GO
INSERT [dbo].[Register] ([Id], [Name], [Email], [Mobile], [Password], [Isadmin]) VALUES (1, N'Punita', N'P@gmail.com', N'1234567891', N'123', 1)
GO
INSERT [dbo].[Register] ([Id], [Name], [Email], [Mobile], [Password], [Isadmin]) VALUES (2, N'Shagun', N's@gmail.com', N'9876543210', N'1234', 0)
GO
INSERT [dbo].[Register] ([Id], [Name], [Email], [Mobile], [Password], [Isadmin]) VALUES (3, N'Sonal', N'k@gmail.com', N'45678', N'p123', 0)
GO
INSERT [dbo].[Register] ([Id], [Name], [Email], [Mobile], [Password], [Isadmin]) VALUES (4, N'Sumit', N's@gmail.com', N'12536874', N'123', 0)
GO
INSERT [dbo].[Register] ([Id], [Name], [Email], [Mobile], [Password], [Isadmin]) VALUES (5, N'Abhishek', N'a@gmail.com', N'123456', N'123', 0)
GO
INSERT [dbo].[Register] ([Id], [Name], [Email], [Mobile], [Password], [Isadmin]) VALUES (6, N'Dolly', N'd@gmail.com', N'457832', N'123', 0)
GO
SET IDENTITY_INSERT [dbo].[Register] OFF

ALTER DATABASE [MvcPrject] SET  READ_WRITE 
GO
