CREATE TABLE [dbo].[InterviewUser] (
    [InterviewUserId] INT IDENTITY (1, 1) NOT NULL,
    [UserId]          INT NOT NULL,
    [InterviewId]     INT NOT NULL,
    PRIMARY KEY CLUSTERED ([InterviewUserId] ASC),
    FOREIGN KEY ([InterviewId]) REFERENCES [dbo].[Interview] ([InterviewId]),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[UserR] ([UserId]),
    UNIQUE NONCLUSTERED ([UserId] ASC, [InterviewId] ASC)
);

