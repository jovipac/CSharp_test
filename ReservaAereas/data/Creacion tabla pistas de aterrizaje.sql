USE [flujoaereo]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 18/03/2019 20:10:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[LandingTrack](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Description] [nvarchar](25) NOT NULL,
	[Status_id] [int] NOT NULL,
 CONSTRAINT [PK_LandingTrack] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO