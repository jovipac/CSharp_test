USE [flujoaereo]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 18/03/2019 20:10:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Plane] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50) NOT NULL,
    [Capacity]   NVARCHAR (50) NOT NULL,
    [Airline_id] INT          NULL,
    [Status_id]  INT          NULL,
    [Type_id]    INT          NULL,
    CONSTRAINT [Plane_pk] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [Status_Plane_fk] FOREIGN KEY ([Status_id]) REFERENCES [dbo].[Status] ([Id]) ON DELETE SET NULL ON UPDATE CASCADE
);

GO