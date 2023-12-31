USE [master]
GO
/****** Object:  Database [DogCatLoverPlatformDB]    Script Date: 27/10/2023 9:22:08 SA ******/
CREATE DATABASE [DogCatLoverPlatformDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DogCatLoverPlatformDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.HALAM_SE170579\MSSQL\DATA\DogCatLoverPlatformDB.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DogCatLoverPlatformDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.HALAM_SE170579\MSSQL\DATA\DogCatLoverPlatformDB_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DogCatLoverPlatformDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET  MULTI_USER 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DogCatLoverPlatformDB]
GO
/****** Object:  Table [dbo].[Configuration]    Script Date: 27/10/2023 9:22:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Configuration](
	[ConfigId] [int] IDENTITY(1,1) NOT NULL,
	[SettingName] [nvarchar](100) NOT NULL,
	[SettingValue] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ConfigId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Exchanges]    Script Date: 27/10/2023 9:22:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exchanges](
	[ExchangeId] [int] IDENTITY(1,1) NOT NULL,
	[UserId1] [int] NULL,
	[UserId2] [int] NULL,
	[ItemType] [nvarchar](50) NOT NULL,
	[ExchangeDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ExchangeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Items]    Script Date: 27/10/2023 9:22:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
	[OwnerId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Posts]    Script Date: 27/10/2023 9:22:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posts](
	[PostId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[PostDate] [datetime] NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reports]    Script Date: 27/10/2023 9:22:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reports](
	[ReportId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[PostId] [int] NULL,
	[ReportReason] [nvarchar](max) NOT NULL,
	[ReportDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReportId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 27/10/2023 9:22:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[RoleID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Configuration] ON 

INSERT [dbo].[Configuration] ([ConfigId], [SettingName], [SettingValue]) VALUES (1, N'MaxPostsPerPage', N'10')
INSERT [dbo].[Configuration] ([ConfigId], [SettingName], [SettingValue]) VALUES (2, N'ReportThreshold', N'3')
SET IDENTITY_INSERT [dbo].[Configuration] OFF
SET IDENTITY_INSERT [dbo].[Exchanges] ON 

INSERT [dbo].[Exchanges] ([ExchangeId], [UserId1], [UserId2], [ItemType], [ExchangeDate]) VALUES (1, 1, 2, N'Gift', CAST(N'2023-10-25 14:15:00.000' AS DateTime))
INSERT [dbo].[Exchanges] ([ExchangeId], [UserId1], [UserId2], [ItemType], [ExchangeDate]) VALUES (2, 2, 1, N'Paid', CAST(N'2023-10-26 16:45:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Exchanges] OFF
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([ItemId], [ItemName], [Description], [Category], [OwnerId]) VALUES (1, N'Dog Bed', N'A comfortable bed for dogs.', N'Accessory', 1)
INSERT [dbo].[Items] ([ItemId], [ItemName], [Description], [Category], [OwnerId]) VALUES (2, N'Cat Toy', N'Interactive toy for cats.', N'Toy', 2)
SET IDENTITY_INSERT [dbo].[Items] OFF
SET IDENTITY_INSERT [dbo].[Posts] ON 

INSERT [dbo].[Posts] ([PostId], [UserId], [Title], [Content], [PostDate], [Status]) VALUES (1, 1, N'My Dog', N'This is a post about my dog.', CAST(N'2023-10-25 10:00:00.000' AS DateTime), N'Published')
INSERT [dbo].[Posts] ([PostId], [UserId], [Title], [Content], [PostDate], [Status]) VALUES (2, 2, N'Cat Care Tips', N'Learn how to take care of your cat.', CAST(N'2023-10-26 08:30:00.000' AS DateTime), N'Pending')
SET IDENTITY_INSERT [dbo].[Posts] OFF
SET IDENTITY_INSERT [dbo].[Reports] ON 

INSERT [dbo].[Reports] ([ReportId], [UserId], [PostId], [ReportReason], [ReportDate]) VALUES (1, 1, 2, N'Inappropriate content', CAST(N'2023-10-26 10:30:00.000' AS DateTime))
INSERT [dbo].[Reports] ([ReportId], [UserId], [PostId], [ReportReason], [ReportDate]) VALUES (2, 2, 1, N'Spam', CAST(N'2023-10-26 11:45:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Reports] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [Email], [UserName], [Password], [RoleID]) VALUES (1, N'user1@gmail.com', N'user1', N'@1234', 0)
INSERT [dbo].[Users] ([UserId], [Email], [UserName], [Password], [RoleID]) VALUES (2, N'user2@gmail.com', N'user2', N'@1234', 0)
INSERT [dbo].[Users] ([UserId], [Email], [UserName], [Password], [RoleID]) VALUES (3, N'staff1@gmail.com', N'staff1', N'staff123', 1)
INSERT [dbo].[Users] ([UserId], [Email], [UserName], [Password], [RoleID]) VALUES (4, N'admin1@example.com', N'admin1', N'admin123', 2)
SET IDENTITY_INSERT [dbo].[Users] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_SettingName]    Script Date: 27/10/2023 9:22:09 SA ******/
ALTER TABLE [dbo].[Configuration] ADD  CONSTRAINT [UQ_SettingName] UNIQUE NONCLUSTERED 
(
	[SettingName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Exchanges_UserId1]    Script Date: 27/10/2023 9:22:09 SA ******/
CREATE NONCLUSTERED INDEX [IX_Exchanges_UserId1] ON [dbo].[Exchanges]
(
	[UserId1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Exchanges_UserId2]    Script Date: 27/10/2023 9:22:09 SA ******/
CREATE NONCLUSTERED INDEX [IX_Exchanges_UserId2] ON [dbo].[Exchanges]
(
	[UserId2] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Posts_UserId]    Script Date: 27/10/2023 9:22:09 SA ******/
CREATE NONCLUSTERED INDEX [IX_Posts_UserId] ON [dbo].[Posts]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_Email]    Script Date: 27/10/2023 9:22:09 SA ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [UQ_Email] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_UserName]    Script Date: 27/10/2023 9:22:09 SA ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [UQ_UserName] UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Exchanges]  WITH CHECK ADD FOREIGN KEY([UserId1])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Exchanges]  WITH CHECK ADD FOREIGN KEY([UserId2])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD FOREIGN KEY([OwnerId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Posts]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Reports]  WITH CHECK ADD FOREIGN KEY([PostId])
REFERENCES [dbo].[Posts] ([PostId])
GO
ALTER TABLE [dbo].[Reports]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
USE [master]
GO
ALTER DATABASE [DogCatLoverPlatformDB] SET  READ_WRITE 
GO
