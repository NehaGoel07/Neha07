create database assignmentASP
go
USE [assignmentASP]
GO
/****** Object:  Table [dbo].[ButtonEvent]    Script Date: 04-03-2020 15:44:30 ******/
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
/****** Object:  Table [dbo].[formData]    Script Date: 04-03-2020 15:44:30 ******/
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
/****** Object:  Table [dbo].[Leaves]    Script Date: 04-03-2020 15:44:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Leaves](
	[Emp_id] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[Leaves_Taken] [int] NULL,
	[Leaves_Left] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ButtonEvent] ([name], [email], [course]) VALUES (N'neha', N'nehag@gmail.com', N'MCA')
GO
INSERT [dbo].[ButtonEvent] ([name], [email], [course]) VALUES (N'dipti', N'dg1@gmail.com', N'MBA')
GO
INSERT [dbo].[formData] ([name], [password], [email_id], [course], [sem]) VALUES (N'neha', N'neha123', N'neha@gmail.com', N'MCA', 6)
GO
INSERT [dbo].[Leaves] ([Emp_id], [Name], [Leaves_Taken], [Leaves_Left]) VALUES (411, N'Neha', 2, 9)
GO
INSERT [dbo].[Leaves] ([Emp_id], [Name], [Leaves_Taken], [Leaves_Left]) VALUES (414, N'Dipti', 4, 7)
GO
INSERT [dbo].[Leaves] ([Emp_id], [Name], [Leaves_Taken], [Leaves_Left]) VALUES (417, N'Hena', 2, 9)
GO
/****** Object:  StoredProcedure [dbo].[Search]    Script Date: 04-03-2020 15:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Search] 
@name varchar(50),@course varchar(50)
as
begin
select email from ButtonEvent
where name like @name and course like @course
end
GO
