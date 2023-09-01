CREATE TABLE [dbo].[JobOpening] (
    [JobOpeningId]  INT           IDENTITY (1, 1) NOT NULL,
    [JobRoleId]     INT           NOT NULL,
    [SeniorityId]   INT           NOT NULL,
    [TeamId]        INT           NOT NULL,
    [OpenPositions] INT           NULL,
    [JobTitle]      VARCHAR (50)  NOT NULL,
    [JobSummary]    VARCHAR (500) NOT NULL,
    [Link]          VARCHAR (100) NULL,
    [WorkHours]     INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([JobOpeningId] ASC),
    FOREIGN KEY ([JobRoleId]) REFERENCES [dbo].[JobRole] ([JobRoleId]),
    FOREIGN KEY ([SeniorityId]) REFERENCES [dbo].[Seniority] ([SeniorityId]),
    FOREIGN KEY ([TeamId]) REFERENCES [dbo].[Team] ([TeamId])
);



