USE [CMPRDatabase]
GO

/****** Object:  Table [dbo].[StudentData]    Script Date: 29-04-2014 17:20:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[StudentData](
	[GrNumber] [int] NOT NULL,
	[StudentName] [varchar](max) NOT NULL,
	[Division] [char](1) NOT NULL,
	[Module] [varchar](50) NULL,
	[Year] [varchar](10) NULL,
	[RollNumber] [int] NOT NULL,
	[MobileNumber] [varchar](15) NOT NULL,
	[EmailId] [varchar](max) NOT NULL,
	[Domain] [varchar](max) NULL,
	[ProjectId] [varchar](20) NULL,
	[GuideName] [varchar](max) NULL,
	[ProjectTitle] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


