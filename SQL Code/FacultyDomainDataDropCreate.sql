USE [CMPRDatabase]
GO

/****** Object:  Table [dbo].[FacultyDomainData]    Script Date: 29-04-2014 17:22:29 ******/
DROP TABLE [dbo].[FacultyDomainData]
GO

/****** Object:  Table [dbo].[FacultyDomainData]    Script Date: 29-04-2014 17:22:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[FacultyDomainData](
	[Faculty Name] [nvarchar](255) NULL,
	[Domain1] [nvarchar](255) NULL,
	[Domain2] [nvarchar](255) NULL,
	[Domain3] [nvarchar](255) NULL,
	[Domain4] [nvarchar](255) NULL,
	[NumberOfMaxProjects] [float] NULL,
	[username] [varchar](20) NULL,
	[passwd] [varchar](50) NULL,
	[AllottedProjects] [int] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


