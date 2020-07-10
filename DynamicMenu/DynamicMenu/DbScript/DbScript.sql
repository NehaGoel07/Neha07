CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 29-06-2020 16:22:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 29-06-2020 16:22:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 29-06-2020 16:22:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 29-06-2020 16:22:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 29-06-2020 16:22:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 29-06-2020 16:22:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 29-06-2020 16:22:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuMaster]    Script Date: 29-06-2020 16:22:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuMaster](
	[MenuIdentity] [int] IDENTITY(1,1) NOT NULL,
	[MenuID] [varchar](30) NOT NULL,
	[MenuName] [varchar](30) NOT NULL,
	[Parent_MenuID] [varchar](30) NOT NULL,
	[User_Roll] [varchar](256) NOT NULL,
	[User_Id] [varchar](20) NULL,
	[MenuFileName] [varchar](100) NOT NULL,
	[MenuURL] [varchar](500) NOT NULL,
	[USE_YN] [char](1) NULL,
	[CreatedDate] [datetime] NULL,
	[IsParent] [bit] NULL,
 CONSTRAINT [PK_MenuMaster] PRIMARY KEY CLUSTERED 
(
	[MenuIdentity] ASC,
	[MenuID] ASC,
	[MenuName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblEmpDetails]    Script Date: 29-06-2020 16:22:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblEmpDetails](
	[emp_id] [int] IDENTITY(101,2) NOT NULL,
	[name] [varchar](50) NULL,
	[address] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200624192847_AddingIdentity', N'5.0.0-preview.5.20278.2')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200625045403_Extend_IdentityUser', N'5.0.0-preview.5.20278.2')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200625071712_Employees', N'5.0.0-preview.5.20278.2')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'06dd8818-2e08-4098-825a-e0c7332eb6be', N'User', N'USER', N'8b7e8b5d-e780-46a0-8f98-42cff695691e')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'5250a49f-62f3-4208-8849-c865005225f5', N'Admin', N'ADMIN', N'd223c9ec-20e2-42fc-97d5-dedfedb72099')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'c89dafec-0224-4d87-bcdb-5960b034fda1', N'Extra', N'EXTRA', N'3c59a5c3-02bc-4a5d-8871-d88f9b3ead08')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2c0ae8cd-415d-4731-820f-c6e8fb4860d1', N'06dd8818-2e08-4098-825a-e0c7332eb6be')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4b3839b9-30ee-497f-8039-41f3528edbfa', N'5250a49f-62f3-4208-8849-c865005225f5')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4c4da8fd-9df9-4789-846c-4b796aeccd4a', N'c89dafec-0224-4d87-bcdb-5960b034fda1')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'255b3978-2c9b-4da0-b0a4-256232c90c13', N'user@user.com', N'USER@USER.COM', N'user@user.com', N'USER@USER.COM', 0, N'AQAAAAEAACcQAAAAEMN1GDUvvKiRkOk1/iGNG4Z8sMChRuUGgGcxpHW6AQVz7XFdivpV34QAF9qQaVIIwA==', N'QCW7A5P2YY2YSIIHGDGYAHIDXQS7GXMX', N'bfe62336-ddb0-4a8a-ae76-6c29a5c46b04', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'2c0ae8cd-415d-4731-820f-c6e8fb4860d1', N'test@gmail.com', N'TEST@GMAIL.COM', N'test@gmail.com', N'TEST@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEF1PfcJhPl9p728Ug7i9/NzpJDbvYAQ6g06JOnj6CAU+hxj5kE0LVw9dDv6/Pn1xfg==', N'LQP34GNZDLRUW7TJDNNYTGJDN2GQOCTM', N'8b8d7761-9980-43b6-989a-45c05ada2351', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4b3839b9-30ee-497f-8039-41f3528edbfa', N'neha@gmail.com', N'NEHA@GMAIL.COM', N'neha@gmail.com', N'NEHA@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEC3q6J23XcXt794/JLs7RQ2SYVoBPk4GBoXayFpGAFCKDSE4a1fd2Fw7SH74MT3UVA==', N'TVDJBQBIFGR2NG2CIJQVNQ6O5PJSGXP4', N'549948e3-2244-4850-b59a-e85fee0eb3c1', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4c4da8fd-9df9-4789-846c-4b796aeccd4a', N'extra@gmail.com', N'EXTRA@GMAIL.COM', N'extra@gmail.com', N'EXTRA@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEOrl/twZKO7eBHQdawRSrPDxJz0AFusTYUqg2H0YuBFJ0Zs13Qu0AHQOuMqwBLD7EQ==', N'4WVAXXV5ARUR3WZJJ7AOZFKMTJFJYBDW', N'ffc12b15-e638-415f-bf11-dfa8626a7913', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[MenuMaster] ON 
GO
INSERT [dbo].[MenuMaster] ([MenuIdentity], [MenuID], [MenuName], [Parent_MenuID], [User_Roll], [User_Id], [MenuFileName], [MenuURL], [USE_YN], [CreatedDate], [IsParent]) VALUES (1, N'AdminUser', N'Roles', N'*', N'ADMIN', NULL, N'ListRoles', N'Admin', N'Y', CAST(N'2020-06-25T12:51:30.150' AS DateTime), 1)
GO
INSERT [dbo].[MenuMaster] ([MenuIdentity], [MenuID], [MenuName], [Parent_MenuID], [User_Roll], [User_Id], [MenuFileName], [MenuURL], [USE_YN], [CreatedDate], [IsParent]) VALUES (2, N'Priv', N'Privacy', N'*', N'Extra', NULL, N'Privacy', N'Home', N'Y', CAST(N'2020-06-25T13:11:14.010' AS DateTime), 1)
GO
INSERT [dbo].[MenuMaster] ([MenuIdentity], [MenuID], [MenuName], [Parent_MenuID], [User_Roll], [User_Id], [MenuFileName], [MenuURL], [USE_YN], [CreatedDate], [IsParent]) VALUES (3, N'Privacy', N'Privacy', N'*', N'Admin', NULL, N'Privacy', N'Home', N'Y', CAST(N'2020-06-25T13:11:14.010' AS DateTime), 0)
GO
INSERT [dbo].[MenuMaster] ([MenuIdentity], [MenuID], [MenuName], [Parent_MenuID], [User_Roll], [User_Id], [MenuFileName], [MenuURL], [USE_YN], [CreatedDate], [IsParent]) VALUES (4, N'CRT_ROLE', N'Create Role', N'AdminUser', N'Admin', NULL, N'CreateRole', N'Admin', N'Y', CAST(N'2020-06-25T13:11:14.010' AS DateTime), 0)
GO
INSERT [dbo].[MenuMaster] ([MenuIdentity], [MenuID], [MenuName], [Parent_MenuID], [User_Roll], [User_Id], [MenuFileName], [MenuURL], [USE_YN], [CreatedDate], [IsParent]) VALUES (5, N'EmpList', N'Employees', N'*', N'Admin', NULL, N'', N'', N'Y', CAST(N'2020-06-25T13:11:14.010' AS DateTime), 1)
GO
INSERT [dbo].[MenuMaster] ([MenuIdentity], [MenuID], [MenuName], [Parent_MenuID], [User_Roll], [User_Id], [MenuFileName], [MenuURL], [USE_YN], [CreatedDate], [IsParent]) VALUES (9, N'EmpList', N'Employees', N'*', N'User', NULL, N'Get', N'Employee', N'Y', CAST(N'2020-06-25T13:11:14.010' AS DateTime), 0)
GO
INSERT [dbo].[MenuMaster] ([MenuIdentity], [MenuID], [MenuName], [Parent_MenuID], [User_Roll], [User_Id], [MenuFileName], [MenuURL], [USE_YN], [CreatedDate], [IsParent]) VALUES (10, N'NewEmp', N'Add', N'EmpList', N'Admin', NULL, N'AddNew', N'Employee', N'Y', CAST(N'2020-06-25T13:11:14.010' AS DateTime), 0)
GO
INSERT [dbo].[MenuMaster] ([MenuIdentity], [MenuID], [MenuName], [Parent_MenuID], [User_Roll], [User_Id], [MenuFileName], [MenuURL], [USE_YN], [CreatedDate], [IsParent]) VALUES (12, N'RoleList', N'List', N'AdminUser', N'Admin', NULL, N'ListRoles', N'Admin', N'Y', CAST(N'2020-06-25T13:11:14.010' AS DateTime), 0)
GO
INSERT [dbo].[MenuMaster] ([MenuIdentity], [MenuID], [MenuName], [Parent_MenuID], [User_Roll], [User_Id], [MenuFileName], [MenuURL], [USE_YN], [CreatedDate], [IsParent]) VALUES (13, N'EMP_LIST', N'List', N'EmpList', N'Admin', NULL, N'Get', N'Employee', N'Y', CAST(N'2020-06-25T13:11:14.010' AS DateTime), 0)
GO
INSERT [dbo].[MenuMaster] ([MenuIdentity], [MenuID], [MenuName], [Parent_MenuID], [User_Roll], [User_Id], [MenuFileName], [MenuURL], [USE_YN], [CreatedDate], [IsParent]) VALUES (19, N'Privacy', N'Privacy', N'Priv', N'Extra', N'extra@gmail.com', N'Privacy', N'Home', N'Y', CAST(N'2020-06-25T13:11:14.010' AS DateTime), 0)
GO
INSERT [dbo].[MenuMaster] ([MenuIdentity], [MenuID], [MenuName], [Parent_MenuID], [User_Roll], [User_Id], [MenuFileName], [MenuURL], [USE_YN], [CreatedDate], [IsParent]) VALUES (20, N'Privacy', N'Privacy', N'*', N'User', NULL, N'Privacy', N'Home', N'Y', CAST(N'2020-06-25T13:11:14.010' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[MenuMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[TblEmpDetails] ON 
GO
INSERT [dbo].[TblEmpDetails] ([emp_id], [name], [address]) VALUES (101, N'Neha', N'Delhi')
GO
INSERT [dbo].[TblEmpDetails] ([emp_id], [name], [address]) VALUES (103, N'Dipti', N'New Delhi')
GO
INSERT [dbo].[TblEmpDetails] ([emp_id], [name], [address]) VALUES (2103, N'Shalu', N'Noida')
GO
INSERT [dbo].[TblEmpDetails] ([emp_id], [name], [address]) VALUES (2105, N'Yati', N'Jodhpur')
GO
SET IDENTITY_INSERT [dbo].[TblEmpDetails] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 29-06-2020 16:22:27 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 29-06-2020 16:22:27 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 29-06-2020 16:22:27 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 29-06-2020 16:22:27 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 29-06-2020 16:22:27 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 29-06-2020 16:22:27 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 29-06-2020 16:22:27 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MenuMaster] ADD  CONSTRAINT [DF__MenuMaste__USE_Y__60A75C0F]  DEFAULT ('Y') FOR [USE_YN]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
