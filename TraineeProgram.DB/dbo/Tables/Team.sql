CREATE TABLE [dbo].[Team] (
    [TeamId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]   VARCHAR (200) NOT NULL,
    PRIMARY KEY CLUSTERED ([TeamId] ASC)
);

