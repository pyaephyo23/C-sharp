USE [OJTAPP]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 9/6/2023 4:25:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[PhNo] [bigint] NULL,
	[Email] [nvarchar](100) NULL,
	[Gender] [nvarchar](10) NULL,
	[EmployeeType] [nvarchar](20) NULL,
	[DateOfBirth] [datetime] NULL,
	[Address] [nvarchar](200) NULL,
	[TownshipId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 9/6/2023 4:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Barcode] [varchar](50) NULL,
	[Name] [varchar](100) NULL,
	[BaseUnitId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Township]    Script Date: 9/6/2023 4:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Township](
	[TownshipId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TownshipId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnitConversion]    Script Date: 9/6/2023 4:25:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnitConversion](
	[ProductId] [int] NULL,
	[BaseUnitId] [int] NULL,
	[Multiplier] [decimal](18, 2) NULL,
	[ToUnitId] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Units]    Script Date: 9/6/2023 4:26:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Units](
	[UnitId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[UnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeId], [Name], [PhNo], [Email], [Gender], [EmployeeType], [DateOfBirth], [Address], [TownshipId]) VALUES (1, N'Pyae', 923456, N'ppk@gmail.com', N'Male', N'Full Time', CAST(N'1999-12-23T00:00:00.000' AS DateTime), N'asdfsdfsdf', 1)
INSERT [dbo].[Employees] ([EmployeeId], [Name], [PhNo], [Email], [Gender], [EmployeeType], [DateOfBirth], [Address], [TownshipId]) VALUES (2, N'Kyaw', 12312313, N'kyaw@gmail.com', N'Male', N'Full Time', CAST(N'2000-02-01T00:00:00.000' AS DateTime), N'sdfsdfs', 2)
INSERT [dbo].[Employees] ([EmployeeId], [Name], [PhNo], [Email], [Gender], [EmployeeType], [DateOfBirth], [Address], [TownshipId]) VALUES (3, N'Pyae Pyae', 923434, N'Pyae@gmail.com', N'Female', N'Part Time', CAST(N'2000-01-31T00:00:00.000' AS DateTime), N'dfdsfsdf', 2)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [Barcode], [Name], [BaseUnitId]) VALUES (9, N'dsfs', N'Pen', 6)
INSERT [dbo].[Products] ([ProductId], [Barcode], [Name], [BaseUnitId]) VALUES (17, N'XXXX', N'Pencil', 6)
INSERT [dbo].[Products] ([ProductId], [Barcode], [Name], [BaseUnitId]) VALUES (18, N'XXXX', N'Chocolate', 10)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Township] ON 

INSERT [dbo].[Township] ([TownshipId], [Name]) VALUES (1, N'Yangon')
INSERT [dbo].[Township] ([TownshipId], [Name]) VALUES (2, N'Mandalay')
INSERT [dbo].[Township] ([TownshipId], [Name]) VALUES (7, N'Mawlamyine')
SET IDENTITY_INSERT [dbo].[Township] OFF
GO
INSERT [dbo].[UnitConversion] ([ProductId], [BaseUnitId], [Multiplier], [ToUnitId]) VALUES (9, 1, CAST(23.00 AS Decimal(18, 2)), 6)
INSERT [dbo].[UnitConversion] ([ProductId], [BaseUnitId], [Multiplier], [ToUnitId]) VALUES (9, 6, CAST(0.24 AS Decimal(18, 2)), 1)
INSERT [dbo].[UnitConversion] ([ProductId], [BaseUnitId], [Multiplier], [ToUnitId]) VALUES (18, 6, CAST(0.25 AS Decimal(18, 2)), 1)
INSERT [dbo].[UnitConversion] ([ProductId], [BaseUnitId], [Multiplier], [ToUnitId]) VALUES (18, 1, CAST(25.00 AS Decimal(18, 2)), 6)
INSERT [dbo].[UnitConversion] ([ProductId], [BaseUnitId], [Multiplier], [ToUnitId]) VALUES (17, 1, CAST(2300.00 AS Decimal(18, 2)), 6)
GO
SET IDENTITY_INSERT [dbo].[Units] ON 

INSERT [dbo].[Units] ([UnitId], [Name]) VALUES (1, N' Each / Pieces')
INSERT [dbo].[Units] ([UnitId], [Name]) VALUES (6, N'Boxes')
INSERT [dbo].[Units] ([UnitId], [Name]) VALUES (10, N'slide')
SET IDENTITY_INSERT [dbo].[Units] OFF
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD FOREIGN KEY([TownshipId])
REFERENCES [dbo].[Township] ([TownshipId])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD FOREIGN KEY([BaseUnitId])
REFERENCES [dbo].[Units] ([UnitId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UnitConversion]  WITH CHECK ADD FOREIGN KEY([BaseUnitId])
REFERENCES [dbo].[Units] ([UnitId])
GO
ALTER TABLE [dbo].[UnitConversion]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ProductId])
GO
ALTER TABLE [dbo].[UnitConversion]  WITH CHECK ADD FOREIGN KEY([ToUnitId])
REFERENCES [dbo].[Units] ([UnitId])
GO
