USE [LabMangement]
GO
/****** Object:  Table [dbo].[ListOfWorks]    Script Date: 7/1/2020 7:31:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListOfWorks](
	[no] [int] NOT NULL,
	[job] [nvarchar](max) NULL,
	[status] [nvarchar](max) NULL,
 CONSTRAINT [PK_ListOfWorks] PRIMARY KEY CLUSTERED 
(
	[no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 7/1/2020 7:31:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[memcode] [nchar](10) NOT NULL,
	[memname] [nvarchar](max) NULL,
	[gender] [nvarchar](max) NULL,
	[birthday] [datetime] NULL,
	[address] [nvarchar](max) NULL,
	[phonenum] [nvarchar](max) NULL,
	[email] [nvarchar](max) NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[memcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemberWork]    Script Date: 7/1/2020 7:31:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberWork](
	[Member_memcode] [nchar](10) NOT NULL,
	[Works_ID] [int] NOT NULL,
 CONSTRAINT [PK_MemberWork] PRIMARY KEY CLUSTERED 
(
	[Member_memcode] ASC,
	[Works_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectListOfWork]    Script Date: 7/1/2020 7:31:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectListOfWork](
	[Project_procode] [nchar](10) NOT NULL,
	[ListOfWorks_no] [int] NOT NULL,
 CONSTRAINT [PK_ProjectListOfWork] PRIMARY KEY CLUSTERED 
(
	[Project_procode] ASC,
	[ListOfWorks_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 7/1/2020 7:31:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[procode] [nchar](10) NOT NULL,
	[proname] [nvarchar](max) NULL,
	[description] [nvarchar](max) NULL,
	[fromdate] [datetime] NULL,
	[todate] [datetime] NULL,
 CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED 
(
	[procode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sysdiagrams]    Script Date: 7/1/2020 7:31:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sysdiagrams](
	[name] [nvarchar](128) NOT NULL,
	[principal_id] [int] NOT NULL,
	[diagram_id] [int] IDENTITY(1,1) NOT NULL,
	[version] [int] NULL,
	[definition] [varbinary](max) NULL,
 CONSTRAINT [PK_sysdiagrams] PRIMARY KEY CLUSTERED 
(
	[diagram_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkProject]    Script Date: 7/1/2020 7:31:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkProject](
	[Work_ID] [int] NOT NULL,
	[Projects_procode] [nchar](10) NOT NULL,
 CONSTRAINT [PK_WorkProject] PRIMARY KEY CLUSTERED 
(
	[Work_ID] ASC,
	[Projects_procode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Works]    Script Date: 7/1/2020 7:31:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Works](
	[ID] [int] NOT NULL,
	[workingtime] [nvarchar](max) NULL,
	[salary] [nvarchar](max) NULL,
 CONSTRAINT [PK_Works] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[MemberWork]  WITH CHECK ADD  CONSTRAINT [FK_MemberWork_Member] FOREIGN KEY([Member_memcode])
REFERENCES [dbo].[Members] ([memcode])
GO
ALTER TABLE [dbo].[MemberWork] CHECK CONSTRAINT [FK_MemberWork_Member]
GO
ALTER TABLE [dbo].[MemberWork]  WITH CHECK ADD  CONSTRAINT [FK_MemberWork_Work] FOREIGN KEY([Works_ID])
REFERENCES [dbo].[Works] ([ID])
GO
ALTER TABLE [dbo].[MemberWork] CHECK CONSTRAINT [FK_MemberWork_Work]
GO
ALTER TABLE [dbo].[ProjectListOfWork]  WITH CHECK ADD  CONSTRAINT [FK_ProjectListOfWork_ListOfWork] FOREIGN KEY([ListOfWorks_no])
REFERENCES [dbo].[ListOfWorks] ([no])
GO
ALTER TABLE [dbo].[ProjectListOfWork] CHECK CONSTRAINT [FK_ProjectListOfWork_ListOfWork]
GO
ALTER TABLE [dbo].[ProjectListOfWork]  WITH CHECK ADD  CONSTRAINT [FK_ProjectListOfWork_Project] FOREIGN KEY([Project_procode])
REFERENCES [dbo].[Projects] ([procode])
GO
ALTER TABLE [dbo].[ProjectListOfWork] CHECK CONSTRAINT [FK_ProjectListOfWork_Project]
GO
ALTER TABLE [dbo].[WorkProject]  WITH CHECK ADD  CONSTRAINT [FK_WorkProject_Project] FOREIGN KEY([Projects_procode])
REFERENCES [dbo].[Projects] ([procode])
GO
ALTER TABLE [dbo].[WorkProject] CHECK CONSTRAINT [FK_WorkProject_Project]
GO
ALTER TABLE [dbo].[WorkProject]  WITH CHECK ADD  CONSTRAINT [FK_WorkProject_Work] FOREIGN KEY([Work_ID])
REFERENCES [dbo].[Works] ([ID])
GO
ALTER TABLE [dbo].[WorkProject] CHECK CONSTRAINT [FK_WorkProject_Work]
GO
