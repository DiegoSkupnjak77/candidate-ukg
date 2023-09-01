CREATE TABLE [dbo].[Reference] (
    [ReferenceId]   INT           IDENTITY (1, 1) NOT NULL,
    [CandidateId]   INT           NOT NULL,
    [UserId]        INT           NOT NULL,
    [ReferenceDate] DATE          NOT NULL,
    [RelatedBy]     VARCHAR (100) NULL,
    [Comments]      VARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([ReferenceId] ASC),
    FOREIGN KEY ([CandidateId]) REFERENCES [dbo].[Candidate] ([CandidateId]),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[UserR] ([UserId])
);

