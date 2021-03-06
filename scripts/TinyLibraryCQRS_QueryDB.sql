USE TinyLibraryCQRS_QueryDB
GO
/****** Object:  ForeignKey [FK_BookTransferHistory_Books]    Script Date: 08/31/2011 19:56:53 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BookTransferHistory_Books]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookTransferHistory]'))
ALTER TABLE [dbo].[BookTransferHistory] DROP CONSTRAINT [FK_BookTransferHistory_Books]
GO
/****** Object:  ForeignKey [FK_BookTransferHistory_UserAccounts]    Script Date: 08/31/2011 19:56:53 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BookTransferHistory_UserAccounts]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookTransferHistory]'))
ALTER TABLE [dbo].[BookTransferHistory] DROP CONSTRAINT [FK_BookTransferHistory_UserAccounts]
GO
/****** Object:  Table [dbo].[BookTransferHistory]    Script Date: 08/31/2011 19:56:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BookTransferHistory]') AND type in (N'U'))
DROP TABLE [dbo].[BookTransferHistory]
GO
/****** Object:  Table [dbo].[UserAccounts]    Script Date: 08/31/2011 19:56:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserAccounts]') AND type in (N'U'))
DROP TABLE [dbo].[UserAccounts]
GO
/****** Object:  Table [dbo].[AdminAccounts]    Script Date: 08/31/2011 19:56:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AdminAccounts]') AND type in (N'U'))
DROP TABLE [dbo].[AdminAccounts]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 08/31/2011 19:56:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Books]') AND type in (N'U'))
DROP TABLE [dbo].[Books]
GO
/****** Object:  Default [DF_AdminAccounts_ID]    Script Date: 08/31/2011 19:56:52 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_AdminAccounts_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[AdminAccounts]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_AdminAccounts_ID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[AdminAccounts] DROP CONSTRAINT [DF_AdminAccounts_ID]
END


End
GO
/****** Object:  Default [DF_Books_ID]    Script Date: 08/31/2011 19:56:52 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Books_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Books]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Books_ID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Books] DROP CONSTRAINT [DF_Books_ID]
END


End
GO
/****** Object:  Default [DF_BookTransferHistory_ID]    Script Date: 08/31/2011 19:56:53 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_BookTransferHistory_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookTransferHistory]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_BookTransferHistory_ID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[BookTransferHistory] DROP CONSTRAINT [DF_BookTransferHistory_ID]
END


End
GO
/****** Object:  Default [DF_UserAccounts_ID]    Script Date: 08/31/2011 19:56:53 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_UserAccounts_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccounts]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_UserAccounts_ID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[UserAccounts] DROP CONSTRAINT [DF_UserAccounts_ID]
END


End
GO
/****** Object:  Table [dbo].[Books]    Script Date: 08/31/2011 19:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Books]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Books](
	[ID] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[Title] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Author] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Description] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ISBN] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Pages] [int] NOT NULL,
	[Inventory] [int] NOT NULL,
	[AggregateRootId] [bigint] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Books] ([ID], [Title], [Author], [Description], [ISBN], [Pages], [Inventory], [AggregateRootId]) VALUES (N'06c6763b-e92c-4068-a4ef-02c593b376c8', N'C# Developer''s Guide to ASP.NET, XML, and ADO.NET', N'Jeffrey P. McManus, Chris Kinsman', N'The book every Internet application developer working with Microsoft development tools needs to retool their knowledge of the new .NET techniques used to build Windows applications.', N'0-672-32155-6', 608, 15, 1217482607900017)
INSERT [dbo].[Books] ([ID], [Title], [Author], [Description], [ISBN], [Pages], [Inventory], [AggregateRootId]) VALUES (N'6e68d1b4-5c00-494d-8b8e-237a8080eb6b', N'A Programmer''s Guide to .NET', N'Alexei Fedorov', N'A book that will help you to gain an in-depth understanding of the .NET framework, its architecture, main components and supported technologies.', N'0-321-11232-6', 720, 20, 1217477433000015)
INSERT [dbo].[Books] ([ID], [Title], [Author], [Description], [ISBN], [Pages], [Inventory], [AggregateRootId]) VALUES (N'eee170b4-6b03-4834-a27d-2a2189cb2489', N'Essential ASP.NET with Examples in C#', N'Fritz Onion', N'This is the C# programmer''s definitive reference for ASP.NET through version 1.1.', N'0-201-76040-1', 432, 6, 1217487270600019)
INSERT [dbo].[Books] ([ID], [Title], [Author], [Description], [ISBN], [Pages], [Inventory], [AggregateRootId]) VALUES (N'2f931950-48d7-4580-a695-b7c9f8b2d50d', N'Architecting Microsoft .NET Solutions for the Enterprise', N'Dino Esposito; Andrea Saltarello', N'In this book, you ll take a structured, realistic approach to resolving software complexity that places architectural integrity at its core.', N'0-7356-2609-X', 304, 3, 1217491263900021)
INSERT [dbo].[Books] ([ID], [Title], [Author], [Description], [ISBN], [Pages], [Inventory], [AggregateRootId]) VALUES (N'98746178-7722-4560-a158-d5ecfb156a2a', N'Essential .NET, Volume 1: The Common Language Runtime', N'Don Box, Chris Sells', N'Provides everything developers need to take full advantage of the power of Microsoft .NET.', N'0-201-73411-7', 432, 7, 1217472778800013)
INSERT [dbo].[Books] ([ID], [Title], [Author], [Description], [ISBN], [Pages], [Inventory], [AggregateRootId]) VALUES (N'03d513fc-04b9-4525-b7d3-f566e2679426', N'Programming Entity Framework, 1st Edition', N'Julia Lerman', N'Programming Entity Framework is a thorough introduction to Microsoft''s new core framework for modeling and accessing data in .NET applications.', N'978-0-596-52028-1', 832, 27, 1217494506500023)
/****** Object:  Table [dbo].[AdminAccounts]    Script Date: 08/31/2011 19:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AdminAccounts]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AdminAccounts](
	[ID] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Password] [nvarchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DisplayName] [nvarchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Email] [nvarchar](64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[AggregateRootId] [bigint] NOT NULL,
 CONSTRAINT [PK_AdminAccounts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[AdminAccounts] ([ID], [UserName], [Password], [DisplayName], [Email], [AggregateRootId]) VALUES (N'546c83e6-e42c-4f2b-8809-dd515756e9ad', N'admin', N'admin', N'Administrator', N'admin@tlibcqrs.com', 1217462878000011)
/****** Object:  Table [dbo].[UserAccounts]    Script Date: 08/31/2011 19:56:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserAccounts]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserAccounts](
	[ID] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Password] [nvarchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[DisplayName] [nvarchar](20) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Email] [nvarchar](64) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ContactPhone] [nvarchar](25) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Address_Country] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Address_State] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Address_Street] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Address_City] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Address_Zip] [nvarchar](8) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[AggregateRootId] [bigint] NOT NULL,
 CONSTRAINT [PK_UserAccounts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[UserAccounts] ([ID], [UserName], [Password], [DisplayName], [Email], [ContactPhone], [Address_Country], [Address_State], [Address_Street], [Address_City], [Address_Zip], [AggregateRootId]) VALUES (N'3ec1f965-4472-4870-8716-2200db376cca', N'daxnet', N'daxnet', N'dax.net', N'daxnet@live.com', N'+86-21-813427', N'China', N'Shanghai', N'No.1234, Dummy Rd, PuDong', N'Shanghai', N'200000', 1217458684000009)
/****** Object:  Table [dbo].[BookTransferHistory]    Script Date: 08/31/2011 19:56:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BookTransferHistory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BookTransferHistory](
	[ID] [uniqueidentifier] NOT NULL,
	[UserID] [uniqueidentifier] NOT NULL,
	[BookID] [uniqueidentifier] NOT NULL,
	[Returned] [bit] NOT NULL,
	[ReturnedDate] [datetime] NULL,
	[BorrowedDate] [datetime] NULL,
 CONSTRAINT [PK_BookTransferHistory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'BookTransferHistory', N'COLUMN',N'Returned'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Transfer Direction, 0 stands for borrow, whereas 1 stands for return.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookTransferHistory', @level2type=N'COLUMN',@level2name=N'Returned'
GO
/****** Object:  Default [DF_AdminAccounts_ID]    Script Date: 08/31/2011 19:56:52 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_AdminAccounts_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[AdminAccounts]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_AdminAccounts_ID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[AdminAccounts] ADD  CONSTRAINT [DF_AdminAccounts_ID]  DEFAULT (newid()) FOR [ID]
END


End
GO
/****** Object:  Default [DF_Books_ID]    Script Date: 08/31/2011 19:56:52 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_Books_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[Books]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Books_ID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Books] ADD  CONSTRAINT [DF_Books_ID]  DEFAULT (newid()) FOR [ID]
END


End
GO
/****** Object:  Default [DF_BookTransferHistory_ID]    Script Date: 08/31/2011 19:56:53 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_BookTransferHistory_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookTransferHistory]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_BookTransferHistory_ID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[BookTransferHistory] ADD  CONSTRAINT [DF_BookTransferHistory_ID]  DEFAULT (newid()) FOR [ID]
END


End
GO
/****** Object:  Default [DF_UserAccounts_ID]    Script Date: 08/31/2011 19:56:53 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_UserAccounts_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[UserAccounts]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_UserAccounts_ID]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[UserAccounts] ADD  CONSTRAINT [DF_UserAccounts_ID]  DEFAULT (newid()) FOR [ID]
END


End
GO
/****** Object:  ForeignKey [FK_BookTransferHistory_Books]    Script Date: 08/31/2011 19:56:53 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BookTransferHistory_Books]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookTransferHistory]'))
ALTER TABLE [dbo].[BookTransferHistory]  WITH CHECK ADD  CONSTRAINT [FK_BookTransferHistory_Books] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([ID])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BookTransferHistory_Books]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookTransferHistory]'))
ALTER TABLE [dbo].[BookTransferHistory] CHECK CONSTRAINT [FK_BookTransferHistory_Books]
GO
/****** Object:  ForeignKey [FK_BookTransferHistory_UserAccounts]    Script Date: 08/31/2011 19:56:53 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BookTransferHistory_UserAccounts]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookTransferHistory]'))
ALTER TABLE [dbo].[BookTransferHistory]  WITH CHECK ADD  CONSTRAINT [FK_BookTransferHistory_UserAccounts] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserAccounts] ([ID])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BookTransferHistory_UserAccounts]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookTransferHistory]'))
ALTER TABLE [dbo].[BookTransferHistory] CHECK CONSTRAINT [FK_BookTransferHistory_UserAccounts]
GO
