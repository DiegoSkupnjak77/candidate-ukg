CREATE TABLE [dbo].[Interview] (
    [InterviewId]     INT            IDENTITY (1, 1) NOT NULL,
    [InterviewTypeId] INT            NOT NULL,
    [InterviewDate]   DATETIME       NOT NULL,
    [Feedback]        VARCHAR (1000) NULL,
    [IsApproved]      BIT            NOT NULL,
    [ProcessId]       INT            NOT NULL,
    [JobOpeningId]    INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([InterviewId] ASC),
    FOREIGN KEY ([InterviewTypeId]) REFERENCES [dbo].[InterviewType] ([InterviewTypeId]),
    FOREIGN KEY ([JobOpeningId]) REFERENCES [dbo].[JobOpening] ([JobOpeningId]),
    FOREIGN KEY ([ProcessId]) REFERENCES [dbo].[Process] ([ProcessId])
);









