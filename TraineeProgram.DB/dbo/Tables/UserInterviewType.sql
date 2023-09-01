CREATE TABLE [dbo].[UserInterviewType] (
    [UserInterviewTypeId] INT IDENTITY (1, 1) NOT NULL,
    [InterviewTypeId]     INT NOT NULL,
    [UserId]              INT NOT NULL,
    PRIMARY KEY CLUSTERED ([UserInterviewTypeId] ASC),
    FOREIGN KEY ([InterviewTypeId]) REFERENCES [dbo].[InterviewType] ([InterviewTypeId]),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[UserR] ([UserId]),
    UNIQUE NONCLUSTERED ([InterviewTypeId] ASC, [UserId] ASC)
);

