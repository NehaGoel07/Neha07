create database assignmentASP
go
USE [assignmentASP]
GO
/****** Object:  Table [dbo].[ButtonEvent]    Script Date: 02-03-2020 15:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ButtonEvent](
	[name] [varchar](50) NULL,
	[email] [varchar](100) NULL,
	[course] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[formData]    Script Date: 02-03-2020 15:21:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[formData](
	[name] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[email_id] [varchar](100) NULL,
	[course] [varchar](20) NULL,
	[sem] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[ButtonEvent] ([name], [email], [course]) VALUES (N'neha', N'nehag@gmail.com', N'MCA')
GO
INSERT [dbo].[ButtonEvent] ([name], [email], [course]) VALUES (N'neha goel', N'ng@gmail.com', N'BCA')
GO
INSERT [dbo].[formData] ([name], [password], [email_id], [course], [sem]) VALUES (N'neha', N'neha123', N'neha@gmail.com', N'MCA', 6)
GO
