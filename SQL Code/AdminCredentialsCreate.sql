USE [CMPRDatabase]
GO

/****** Object:  Table [dbo].[AdminCredentials]    Script Date: 29-04-2014 17:20:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[AdminCredentials](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[GuideName] [varchar](50) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


