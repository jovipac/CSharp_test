USE [flujoaereo]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 18/03/2019 20:10:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FlightSchedule]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Date] DATE NOT NULL, 
    [Admission_time] DATETIME NULL, 
    [Origin] NVARCHAR(100) NULL, 
    [Departure_time] DATETIME NULL, 
    [Destination] NVARCHAR(100) NULL, 
    [Plane_id] INT NOT NULL,
	[Status_id] INT NOT NULL

    CONSTRAINT [Plane_fk] FOREIGN KEY ([Plane_id]) REFERENCES [dbo].[Plane] ([Id])
    CONSTRAINT [Status_FlightSchedule_fk] FOREIGN KEY ([Status_id]) REFERENCES [dbo].[Status] ([Id])
)

GO