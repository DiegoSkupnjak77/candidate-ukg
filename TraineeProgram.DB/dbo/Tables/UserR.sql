CREATE TABLE [dbo].[UserR] (
    [UserId]      INT             IDENTITY (1, 1) NOT NULL,
    [FirstName]   VARCHAR (30)    NOT NULL,
    [LastName]    VARCHAR (30)    NOT NULL,
    [Email]       VARCHAR (60)    NOT NULL,
    [IsActive]    BIT             NOT NULL,
    [JobRoleId]   INT             NOT NULL,
    [SeniorityId] INT             NOT NULL,
    [Photo]       VARBINARY (MAX) NULL,
    [TeamId]      INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC),
    FOREIGN KEY ([JobRoleId]) REFERENCES [dbo].[JobRole] ([JobRoleId]),
    FOREIGN KEY ([SeniorityId]) REFERENCES [dbo].[Seniority] ([SeniorityId]),
    FOREIGN KEY ([TeamId]) REFERENCES [dbo].[Team] ([TeamId]),
    UNIQUE NONCLUSTERED ([Email] ASC)
);













