USE [Vehicle_Management]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 1/18/2020 8:19:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Employee_Id] [int] IDENTITY(1,1) NOT NULL,
	[First_Name] [varchar](500) NULL,
	[Last_Name] [varchar](500) NULL,
	[Employee_Code] [varchar](50) NULL,
	[Gender] [varchar](10) NULL,
	[DOJ] [datetime] NULL,
	[Designation] [int] NULL,
	[Employee_Type] [int] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Employee_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicle_Assign]    Script Date: 1/18/2020 8:19:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle_Assign](
	[Vehicle_Assign_Id] [int] NOT NULL,
	[Vehicle_Id] [int] NULL,
	[Assign_To] [int] NULL,
	[Assigned_By] [int] NULL,
	[Assigned_Date] [datetime] NULL,
	[Reason] [varchar](500) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Vehicle_Assign] PRIMARY KEY CLUSTERED 
(
	[Vehicle_Assign_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicle_Type]    Script Date: 1/18/2020 8:19:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle_Type](
	[Vehicle_Type_Id] [int] IDENTITY(1,1) NOT NULL,
	[Vehicle_Type] [varchar](500) NULL,
 CONSTRAINT [PK_Tbl_Vehicle_Type] PRIMARY KEY CLUSTERED 
(
	[Vehicle_Type_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleDetails]    Script Date: 1/18/2020 8:19:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleDetails](
	[Vehicle_Id] [int] IDENTITY(1,1) NOT NULL,
	[Vehicle_Type] [int] NOT NULL,
	[Purchase_Year] [nvarchar](max) NULL,
	[Vehicle_Number] [nvarchar](max) NULL,
	[Make_of_Vehicle] [nvarchar](max) NULL,
	[Model] [nvarchar](max) NULL,
	[Colour] [nvarchar](max) NULL,
	[Current_Mileage] [nvarchar](max) NULL,
	[Vehicle_Engine] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.VehicleDetails] PRIMARY KEY CLUSTERED 
(
	[Vehicle_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Vehicle_Type] ON 

INSERT [dbo].[Vehicle_Type] ([Vehicle_Type_Id], [Vehicle_Type]) VALUES (1, N'Two Wheeler')
INSERT [dbo].[Vehicle_Type] ([Vehicle_Type_Id], [Vehicle_Type]) VALUES (2, N'Four Wheeler')
SET IDENTITY_INSERT [dbo].[Vehicle_Type] OFF
SET IDENTITY_INSERT [dbo].[VehicleDetails] ON 

INSERT [dbo].[VehicleDetails] ([Vehicle_Id], [Vehicle_Type], [Purchase_Year], [Vehicle_Number], [Make_of_Vehicle], [Model], [Colour], [Current_Mileage], [Vehicle_Engine], [Description]) VALUES (1, 1, N'3123', N'23123', N'212312', NULL, N'weqwe', N'qweqwe', N'Petrol', N'weqweqwe')
INSERT [dbo].[VehicleDetails] ([Vehicle_Id], [Vehicle_Type], [Purchase_Year], [Vehicle_Number], [Make_of_Vehicle], [Model], [Colour], [Current_Mileage], [Vehicle_Engine], [Description]) VALUES (2, 2, N'134234', N'21312', N'21312', NULL, N'sdfsdf', N'dfsdfd', N'Desil', N'ASas')
SET IDENTITY_INSERT [dbo].[VehicleDetails] OFF
