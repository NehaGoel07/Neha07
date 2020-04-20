create db [Student]
USE [Student]
GO
/****** Object:  Table [dbo].[LoginStudent]    Script Date: 20-04-2020 14:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginStudent](
	[loginId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](25) NULL,
	[Password] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[loginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Nav]    Script Date: 20-04-2020 14:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Nav](
	[navId] [int] IDENTITY(1,1) NOT NULL,
	[navHref] [varchar](25) NULL,
	[navTabName] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[navId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_StudentDetails]    Script Date: 20-04-2020 14:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_StudentDetails](
	[studentId] [int] IDENTITY(1,1) NOT NULL,
	[studentName] [varchar](50) NULL,
	[Course] [varchar](25) NULL,
	[Address] [varchar](max) NULL,
	[Email] [varchar](50) NULL,
	[Gender] [varchar](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[studentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LoginStudent] ON 
GO
INSERT [dbo].[LoginStudent] ([loginId], [Username], [Password]) VALUES (1, N'Neha', N'neha123')
GO
INSERT [dbo].[LoginStudent] ([loginId], [Username], [Password]) VALUES (2, N'Dipti', N'dp123')
GO
INSERT [dbo].[LoginStudent] ([loginId], [Username], [Password]) VALUES (3, N'Komal', N'km123')
GO
SET IDENTITY_INSERT [dbo].[LoginStudent] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Nav] ON 
GO
INSERT [dbo].[tbl_Nav] ([navId], [navHref], [navTabName]) VALUES (1, N'/Ques1', N'Question1')
GO
INSERT [dbo].[tbl_Nav] ([navId], [navHref], [navTabName]) VALUES (2, N'/Ques2', N'Question2')
GO
INSERT [dbo].[tbl_Nav] ([navId], [navHref], [navTabName]) VALUES (3, N'/Ques3', N'Question3')
GO
INSERT [dbo].[tbl_Nav] ([navId], [navHref], [navTabName]) VALUES (4, N'/Ques4', N'Question4')
GO
INSERT [dbo].[tbl_Nav] ([navId], [navHref], [navTabName]) VALUES (5, N'/Calculator', N'Calculator')
GO
INSERT [dbo].[tbl_Nav] ([navId], [navHref], [navTabName]) VALUES (6, N'/Login', N'Login')
GO
SET IDENTITY_INSERT [dbo].[tbl_Nav] OFF
GO
SET IDENTITY_INSERT [dbo].[Tbl_StudentDetails] ON 
GO
INSERT [dbo].[Tbl_StudentDetails] ([studentId], [studentName], [Course], [Address], [Email], [Gender]) VALUES (1, N'Dipti', N'MSc', N'East Delhi', N'dipti@gmail.com', N'Female')
GO
INSERT [dbo].[Tbl_StudentDetails] ([studentId], [studentName], [Course], [Address], [Email], [Gender]) VALUES (2, N'Neha', N'MCA', N'East Delhi', N'neha@gmail.com', N'Female')
GO
INSERT [dbo].[Tbl_StudentDetails] ([studentId], [studentName], [Course], [Address], [Email], [Gender]) VALUES (4, N'Yati', N'MCA', N'Netherlands', N'yati@gmail.com', N'Female')
GO
INSERT [dbo].[Tbl_StudentDetails] ([studentId], [studentName], [Course], [Address], [Email], [Gender]) VALUES (5, N'Anil', N'MTech', N'Delhi', N'anil@gmail.com', N'Male')
GO
INSERT [dbo].[Tbl_StudentDetails] ([studentId], [studentName], [Course], [Address], [Email], [Gender]) VALUES (6, N'Shalu', N'Statistics', N'Delhi', N'shalu@gmail.com', N'Female')
GO
INSERT [dbo].[Tbl_StudentDetails] ([studentId], [studentName], [Course], [Address], [Email], [Gender]) VALUES (9, N'Neeraj', N'MBBS', N'Delhi', N'neeraj@gmail.com', N'Male')
GO
INSERT [dbo].[Tbl_StudentDetails] ([studentId], [studentName], [Course], [Address], [Email], [Gender]) VALUES (11, N'Hena', N'MCA', N'Delhi', N'hena@gmail.com', N'Female')
GO
INSERT [dbo].[Tbl_StudentDetails] ([studentId], [studentName], [Course], [Address], [Email], [Gender]) VALUES (12, N'Bineeta', N'MCA', N'Nainital', N'bineeta@gmail.com', N'Female')
GO
INSERT [dbo].[Tbl_StudentDetails] ([studentId], [studentName], [Course], [Address], [Email], [Gender]) VALUES (14, N'Megha', N'MCA', N'Delhi', N'megha@gmail.com', N'Female')
GO
SET IDENTITY_INSERT [dbo].[Tbl_StudentDetails] OFF
GO
/****** Object:  StoredProcedure [dbo].[usp_AddStudent]    Script Date: 20-04-2020 14:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_AddStudent]
@studentName varchar(50),
@Course varchar(25),
@Address varchar(max),
@Email varchar(50),
@Gender varchar(7)
as
begin
insert into Tbl_StudentDetails values (@studentName,@Course,@Address,@Email,@Gender)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateStudent]    Script Date: 20-04-2020 14:07:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_UpdateStudent]
@studentId int,
@studentName varchar(50),
@Course varchar(25),
@Address varchar(max),
@Email varchar(50),
@Gender varchar(7)
as
begin
update Tbl_StudentDetails
set 
studentName=@studentName,
Course=@Course,
[Address]=@Address,
Email=@Email,
Gender=@Gender
where studentId=@studentId
end
GO
