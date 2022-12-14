IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'SalamaDb')
  BEGIN
    CREATE DATABASE [SalamaDb]


    END
    GO

USE [SalamaDb]
GO
/****** Object:  Table [dbo].[SetUpDetailTbl]    Script Date: 10/15/2022 1:39:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUpDetailTbl](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SetupId] [int] NULL,
	[Name] [varchar](50) NULL,
	[IsActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SetUpTbl]    Script Date: 10/15/2022 1:39:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SetUpTbl](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[IsActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SetUpDetailTbl] ON 

INSERT [dbo].[SetUpDetailTbl] ([ID], [SetupId], [Name], [IsActive]) VALUES (1, 1, N'Suzuki', 1)
INSERT [dbo].[SetUpDetailTbl] ([ID], [SetupId], [Name], [IsActive]) VALUES (2, 1, N'Honda', 1)
INSERT [dbo].[SetUpDetailTbl] ([ID], [SetupId], [Name], [IsActive]) VALUES (3, 1, N'Toyota', 1)
INSERT [dbo].[SetUpDetailTbl] ([ID], [SetupId], [Name], [IsActive]) VALUES (4, 2, N'2020', 1)
INSERT [dbo].[SetUpDetailTbl] ([ID], [SetupId], [Name], [IsActive]) VALUES (5, 2, N'2021', 1)
INSERT [dbo].[SetUpDetailTbl] ([ID], [SetupId], [Name], [IsActive]) VALUES (6, 2, N'2022', 1)
INSERT [dbo].[SetUpDetailTbl] ([ID], [SetupId], [Name], [IsActive]) VALUES (7, 3, N'Hatchback', 1)
INSERT [dbo].[SetUpDetailTbl] ([ID], [SetupId], [Name], [IsActive]) VALUES (8, 3, N'Solo', 1)
INSERT [dbo].[SetUpDetailTbl] ([ID], [SetupId], [Name], [IsActive]) VALUES (9, 3, N'Jeep', 1)
INSERT [dbo].[SetUpDetailTbl] ([ID], [SetupId], [Name], [IsActive]) VALUES (10, 4, N'A', 1)
INSERT [dbo].[SetUpDetailTbl] ([ID], [SetupId], [Name], [IsActive]) VALUES (11, 4, N'B', 1)
INSERT [dbo].[SetUpDetailTbl] ([ID], [SetupId], [Name], [IsActive]) VALUES (12, 4, N'C', 1)
INSERT [dbo].[SetUpDetailTbl] ([ID], [SetupId], [Name], [IsActive]) VALUES (13, 1, N'BMW', 1)
INSERT [dbo].[SetUpDetailTbl] ([ID], [SetupId], [Name], [IsActive]) VALUES (14, 4, N'D', 1)
INSERT [dbo].[SetUpDetailTbl] ([ID], [SetupId], [Name], [IsActive]) VALUES (15, 4, N'E', 1)
SET IDENTITY_INSERT [dbo].[SetUpDetailTbl] OFF
SET IDENTITY_INSERT [dbo].[SetUpTbl] ON 

INSERT [dbo].[SetUpTbl] ([Id], [Name], [IsActive]) VALUES (1, N'Car Make', 1)
INSERT [dbo].[SetUpTbl] ([Id], [Name], [IsActive]) VALUES (2, N'Car Model', 1)
INSERT [dbo].[SetUpTbl] ([Id], [Name], [IsActive]) VALUES (3, N'Car Body Type', 1)
INSERT [dbo].[SetUpTbl] ([Id], [Name], [IsActive]) VALUES (4, N'Trim', 1)
SET IDENTITY_INSERT [dbo].[SetUpTbl] OFF
ALTER TABLE [dbo].[SetUpDetailTbl]  WITH CHECK ADD FOREIGN KEY([SetupId])
REFERENCES [dbo].[SetUpTbl] ([Id])
GO
