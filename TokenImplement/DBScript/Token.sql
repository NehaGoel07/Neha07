create database [Token]
USE [Token]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 17-03-2020 21:35:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[userName] [varchar](50) NULL,
	[pass] [varchar](20) NULL,
	[Roles] [varchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Login] ([userName], [pass], [Roles]) VALUES (N'Neha', N'neha123', N'User')
GO
INSERT [dbo].[Login] ([userName], [pass], [Roles]) VALUES (N'admin', N'admin', N'admin')
GO
INSERT [dbo].[Login] ([userName], [pass], [Roles]) VALUES (N'Ankit', N'ankit123', N'user')
GO

