USE [flujoaereo]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 18/03/2019 20:10:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY NOT NULL,
	[Fullname] [nvarchar](100) NULL,
	[Username] [nvarchar](25) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [Users_pk] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE Status (
                Id INT IDENTITY NOT NULL,
                Name NVARCHAR(50) NOT NULL,
                Category_id INT NOT NULL,
                CONSTRAINT Status_pk PRIMARY KEY (Id)
);
