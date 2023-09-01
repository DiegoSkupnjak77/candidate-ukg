CREATE TABLE [dbo].[Seniority] (
    [SeniorityId] INT           IDENTITY (1, 1) NOT NULL,
    [Code]        VARCHAR (20)  NOT NULL,
    [Description] VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([SeniorityId] ASC)
);

