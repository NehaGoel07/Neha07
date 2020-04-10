create database [BootCamp2020]
USE [BootCamp2020]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 10-04-2020 02:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[emp_id] [int] NOT NULL,
	[emp_name] [varchar](50) NULL,
	[salary] [money] NULL,
	[gender] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_Employees]    Script Date: 10-04-2020 02:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_Employees](
	[emp_id] [int] IDENTITY(100,1) NOT NULL,
	[emp_name] [varchar](50) NULL,
	[emp_dob] [datetime2](3) NULL,
	[emp_salary] [money] NULL,
	[manager_id] [int] NULL,
	[IsTrainer] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Employees] ([emp_id], [emp_name], [salary], [gender]) VALUES (100, N'Neha', 15000.0000, N'Female')
GO
INSERT [dbo].[Employees] ([emp_id], [emp_name], [salary], [gender]) VALUES (101, N'Sonal Jha', 15000.0000, N'Female')
GO
INSERT [dbo].[Employees] ([emp_id], [emp_name], [salary], [gender]) VALUES (102, N'Vijay', 15000.0000, N'Male')
GO
SET IDENTITY_INSERT [dbo].[TBL_Employees] ON 
GO
INSERT [dbo].[TBL_Employees] ([emp_id], [emp_name], [emp_dob], [emp_salary], [manager_id], [IsTrainer]) VALUES (100, N'Neha', CAST(N'1995-08-07T00:00:00.0000000' AS DateTime2), 15100.0000, 111, 0)
GO
INSERT [dbo].[TBL_Employees] ([emp_id], [emp_name], [emp_dob], [emp_salary], [manager_id], [IsTrainer]) VALUES (102, N'Vijay', CAST(N'1995-11-22T00:00:00.0000000' AS DateTime2), 15000.0000, 112, 0)
GO
INSERT [dbo].[TBL_Employees] ([emp_id], [emp_name], [emp_dob], [emp_salary], [manager_id], [IsTrainer]) VALUES (103, N'Vishesh', CAST(N'1997-08-22T00:00:00.0000000' AS DateTime2), 15000.0000, 113, 0)
GO
INSERT [dbo].[TBL_Employees] ([emp_id], [emp_name], [emp_dob], [emp_salary], [manager_id], [IsTrainer]) VALUES (104, N'Abhishek', CAST(N'1997-09-25T00:00:00.0000000' AS DateTime2), 15000.0000, 112, 0)
GO
INSERT [dbo].[TBL_Employees] ([emp_id], [emp_name], [emp_dob], [emp_salary], [manager_id], [IsTrainer]) VALUES (105, N'Shagun', CAST(N'1997-02-13T00:00:00.0000000' AS DateTime2), 15000.0000, 110, 0)
GO
INSERT [dbo].[TBL_Employees] ([emp_id], [emp_name], [emp_dob], [emp_salary], [manager_id], [IsTrainer]) VALUES (106, N'Punita', CAST(N'1997-04-17T00:00:00.0000000' AS DateTime2), 15000.0000, 111, 0)
GO
INSERT [dbo].[TBL_Employees] ([emp_id], [emp_name], [emp_dob], [emp_salary], [manager_id], [IsTrainer]) VALUES (107, N'Latika', CAST(N'1995-09-17T00:00:00.0000000' AS DateTime2), 15000.0000, 113, 0)
GO
INSERT [dbo].[TBL_Employees] ([emp_id], [emp_name], [emp_dob], [emp_salary], [manager_id], [IsTrainer]) VALUES (108, N'Arpit', CAST(N'1995-10-20T00:00:00.0000000' AS DateTime2), 15000.0000, 111, 0)
GO
INSERT [dbo].[TBL_Employees] ([emp_id], [emp_name], [emp_dob], [emp_salary], [manager_id], [IsTrainer]) VALUES (109, N'Azeem', CAST(N'1995-03-21T00:00:00.0000000' AS DateTime2), 15000.0000, 113, 0)
GO
INSERT [dbo].[TBL_Employees] ([emp_id], [emp_name], [emp_dob], [emp_salary], [manager_id], [IsTrainer]) VALUES (110, N'Sachin', CAST(N'1985-03-21T00:00:00.0000000' AS DateTime2), 70000.0000, NULL, 1)
GO
INSERT [dbo].[TBL_Employees] ([emp_id], [emp_name], [emp_dob], [emp_salary], [manager_id], [IsTrainer]) VALUES (111, N'Sakshi', CAST(N'1987-05-04T00:00:00.0000000' AS DateTime2), 50000.0000, 110, 1)
GO
INSERT [dbo].[TBL_Employees] ([emp_id], [emp_name], [emp_dob], [emp_salary], [manager_id], [IsTrainer]) VALUES (112, N'Ritesh', CAST(N'1986-01-01T00:00:00.0000000' AS DateTime2), 50000.0000, 110, 1)
GO
INSERT [dbo].[TBL_Employees] ([emp_id], [emp_name], [emp_dob], [emp_salary], [manager_id], [IsTrainer]) VALUES (113, N'Ashish', CAST(N'1988-04-15T00:00:00.0000000' AS DateTime2), 50000.0000, 110, 1)
GO
INSERT [dbo].[TBL_Employees] ([emp_id], [emp_name], [emp_dob], [emp_salary], [manager_id], [IsTrainer]) VALUES (116, N'Sonal', CAST(N'1998-07-25T00:00:00.0000000' AS DateTime2), 15000.0000, 112, 0)
GO
INSERT [dbo].[TBL_Employees] ([emp_id], [emp_name], [emp_dob], [emp_salary], [manager_id], [IsTrainer]) VALUES (117, N'Bineeta', CAST(N'1996-05-28T00:00:00.0000000' AS DateTime2), 23000.0000, 402, 1)
GO
INSERT [dbo].[TBL_Employees] ([emp_id], [emp_name], [emp_dob], [emp_salary], [manager_id], [IsTrainer]) VALUES (118, N'Yati', CAST(N'1990-10-26T00:00:00.0000000' AS DateTime2), 50000.0000, 404, 1)
GO
INSERT [dbo].[TBL_Employees] ([emp_id], [emp_name], [emp_dob], [emp_salary], [manager_id], [IsTrainer]) VALUES (120, N'Anil', CAST(N'1993-01-09T00:00:00.0000000' AS DateTime2), 50000.0000, 101, NULL)
GO
SET IDENTITY_INSERT [dbo].[TBL_Employees] OFF
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteRecord]    Script Date: 10-04-2020 02:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[usp_deleteRecord]
@emp_name varchar(50)
as
begin
delete from TBL_Employees 
where emp_name=@emp_name
end
GO
/****** Object:  StoredProcedure [dbo].[usp_employeeDetails]    Script Date: 10-04-2020 02:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_employeeDetails](@emp_id int)
as
begin
select * from TBL_Employees where emp_id=@emp_id
end
GO
/****** Object:  StoredProcedure [dbo].[usp_InsertEmp]    Script Date: 10-04-2020 02:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_InsertEmp]
@emp_name varchar(50),
@emp_dob date,
@emp_salary money,
@manager_id int,
@IsTrainer bit
as
begin
insert into TBL_Employees
values(
@emp_name,
@emp_dob,
@emp_salary,
@manager_id,
@IsTrainer)
end
GO
/****** Object:  StoredProcedure [dbo].[usp_Manager]    Script Date: 10-04-2020 02:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_Manager]
 as
 begin
 select a.emp_name,b.emp_name from TBL_Employees a left join TBL_Employees b
 on a.manager_id=b.emp_id; 
 end
GO
