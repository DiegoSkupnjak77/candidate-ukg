CREATE TABLE [dbo].[CandidateJobOpening] (
    [CandidateJobOpeningId] INT      IDENTITY (1, 1) NOT NULL,
    [CandidateId]           INT      NOT NULL,
    [JobOpeningId]          INT      NOT NULL,
    [PostulationDate]       DATETIME NULL,
    PRIMARY KEY CLUSTERED ([CandidateJobOpeningId] ASC),
    FOREIGN KEY ([CandidateId]) REFERENCES [dbo].[Candidate] ([CandidateId]),
    FOREIGN KEY ([JobOpeningId]) REFERENCES [dbo].[JobOpening] ([JobOpeningId])
);

