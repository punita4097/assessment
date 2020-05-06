
create database Assignment1
USE [Assignment1]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 2/28/2020 3:11:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[emp_id] [int] IDENTITY(4000,1) NOT NULL,
	[emp_name] [varchar](255) NULL,
	[mobile] [varchar](10) NULL,
	[dob] [date] NULL,
	[address] [varchar](255) NULL,
	[pincode] [varchar](6) NULL,
	[salary] [int] NULL,
	[isactive] [bit] NULL,
	[created_date] [datetime2](7) NULL,
	[modified_date] [datetime2](7) NULL,
	[phone] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[record]    Script Date: 2/28/2020 3:11:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[record](
	[emp_id] [int] NULL,
	[month] [varchar](20) NULL,
	[salary] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 
GO
INSERT [dbo].[Employee] ([emp_id], [emp_name], [mobile], [dob], [address], [pincode], [salary], [isactive], [created_date], [modified_date], [phone]) VALUES (4000, N'Punita', N'6876543210', CAST(N'1997-04-05' AS Date), N'Faridabad', N'121003', NULL, 1, CAST(N'2020-02-27T16:32:46.7966667' AS DateTime2), CAST(N'2020-02-27T16:32:46.7966667' AS DateTime2), NULL)
GO
INSERT [dbo].[Employee] ([emp_id], [emp_name], [mobile], [dob], [address], [pincode], [salary], [isactive], [created_date], [modified_date], [phone]) VALUES (4001, N'Neha', N'8876543210', CAST(N'1997-03-08' AS Date), N'sarai', N'121003', NULL, 1, CAST(N'2020-02-27T16:32:46.7966667' AS DateTime2), CAST(N'2020-02-27T16:32:46.7966667' AS DateTime2), NULL)
GO
INSERT [dbo].[Employee] ([emp_id], [emp_name], [mobile], [dob], [address], [pincode], [salary], [isactive], [created_date], [modified_date], [phone]) VALUES (4002, N'Arpit', N'9876543210', CAST(N'1997-07-08' AS Date), N'delhi', N'131003', NULL, 1, CAST(N'2020-02-27T16:32:46.7966667' AS DateTime2), CAST(N'2020-02-27T16:32:46.7966667' AS DateTime2), NULL)
GO
INSERT [dbo].[Employee] ([emp_id], [emp_name], [mobile], [dob], [address], [pincode], [salary], [isactive], [created_date], [modified_date], [phone]) VALUES (4003, N'Shagun', N'7876543210', CAST(N'1997-06-09' AS Date), N'Badarpur', N'141003', NULL, 1, CAST(N'2020-02-27T16:32:46.7966667' AS DateTime2), CAST(N'2020-02-27T16:32:46.7966667' AS DateTime2), NULL)
GO
INSERT [dbo].[Employee] ([emp_id], [emp_name], [mobile], [dob], [address], [pincode], [salary], [isactive], [created_date], [modified_date], [phone]) VALUES (4004, N'Sonal', N'6876543210', CAST(N'1997-05-05' AS Date), N'dwarka', N'151003', NULL, 1, CAST(N'2020-02-27T16:32:46.7966667' AS DateTime2), CAST(N'2020-02-27T16:32:46.7966667' AS DateTime2), NULL)
GO
INSERT [dbo].[Employee] ([emp_id], [emp_name], [mobile], [dob], [address], [pincode], [salary], [isactive], [created_date], [modified_date], [phone]) VALUES (4005, N'Abhishek', N'6976543210', CAST(N'1997-02-07' AS Date), N'patel nagar', N'161003', NULL, 1, CAST(N'2020-02-27T16:32:46.8000000' AS DateTime2), CAST(N'2020-02-27T16:32:46.8000000' AS DateTime2), NULL)
GO
INSERT [dbo].[Employee] ([emp_id], [emp_name], [mobile], [dob], [address], [pincode], [salary], [isactive], [created_date], [modified_date], [phone]) VALUES (4006, N'Latika', N'8276543210', CAST(N'1997-01-03' AS Date), N'karol bagh', N'171003', NULL, 1, CAST(N'2020-02-27T16:32:46.8000000' AS DateTime2), CAST(N'2020-02-27T16:32:46.8000000' AS DateTime2), NULL)
GO
INSERT [dbo].[Employee] ([emp_id], [emp_name], [mobile], [dob], [address], [pincode], [salary], [isactive], [created_date], [modified_date], [phone]) VALUES (4007, N'Vishesh', N'7876543219', CAST(N'1997-04-02' AS Date), N'rajiv chowk', N'181003', NULL, 1, CAST(N'2020-02-27T16:32:46.8000000' AS DateTime2), CAST(N'2020-02-27T16:32:46.8000000' AS DateTime2), NULL)
GO
INSERT [dbo].[Employee] ([emp_id], [emp_name], [mobile], [dob], [address], [pincode], [salary], [isactive], [created_date], [modified_date], [phone]) VALUES (4008, N'Azeem', N'6876543217', CAST(N'1997-06-06' AS Date), N'dilshad garden', N'191003', NULL, 1, CAST(N'2020-02-27T16:32:46.8000000' AS DateTime2), CAST(N'2020-02-27T16:32:46.8000000' AS DateTime2), NULL)
GO
INSERT [dbo].[Employee] ([emp_id], [emp_name], [mobile], [dob], [address], [pincode], [salary], [isactive], [created_date], [modified_date], [phone]) VALUES (4009, N'Vijay', N'6876543106', CAST(N'1997-04-11' AS Date), N'janakpuri', N'171002', NULL, 1, CAST(N'2020-02-27T16:32:46.8000000' AS DateTime2), CAST(N'2020-02-27T16:32:46.8000000' AS DateTime2), NULL)
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4000, N'january', 9000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4002, N'february', 8000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4000, N'march', 7000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4002, N'april', 6000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4000, N'may', 5000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4002, N'june', 4000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4001, N'january', 3000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4003, N'february', 2000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4001, N'march', 9000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4003, N'april', 8000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4001, N'may', 7000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4003, N'june', 6000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4005, N'jan', 5000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4004, N'january', 4000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4005, N'february', 3000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4004, N'march', 2000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4005, N'april', 1000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4004, N'may', 9000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4006, N'january', 8000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4007, N'february', 7000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4006, N'march', 6000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4007, N'april', 5000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4006, N'may', 5500)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4007, N'june', 2000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4008, N'january', 1000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4009, N'february', 2000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4008, N'march', 3000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4009, N'april', 4000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4008, N'may', 5500)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4009, N'june', 2000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4000, N'july', 1000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4001, N'july', 2000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4002, N'july', 3000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4003, N'july', 4000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4004, N'july', 5500)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4005, N'july', 2000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4006, N'july', 2000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4007, N'july', 2000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4008, N'july', 2000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4009, N'july', 2000)
GO
INSERT [dbo].[record] ([emp_id], [month], [salary]) VALUES (4009, N'july', 2000)
GO
ALTER TABLE [dbo].[record]  WITH CHECK ADD FOREIGN KEY([emp_id])
REFERENCES [dbo].[Employee] ([emp_id])
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [c] CHECK  (([mobile] like '[6-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [c]
GO
