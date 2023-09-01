CREATE TABLE [dbo].[JobOpening] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [position]      VARCHAR (50)  NOT NULL,
    [openPositions] INT           NULL,
    [department]    VARCHAR (30)  NULL,
    [jobTitle]      VARCHAR (50)  NOT NULL,
    [jobSummary]    VARCHAR (300) NOT NULL,
    [link]          VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

