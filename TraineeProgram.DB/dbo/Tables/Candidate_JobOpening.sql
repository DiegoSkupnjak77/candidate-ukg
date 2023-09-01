CREATE TABLE [dbo].[Candidate_JobOpening] (
    [idCandidate]  INT NOT NULL,
    [idJobOpening] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([idCandidate] ASC, [idJobOpening] ASC),
    FOREIGN KEY ([idCandidate]) REFERENCES [dbo].[Candidate] ([id]),
    FOREIGN KEY ([idJobOpening]) REFERENCES [dbo].[JobOpening] ([id])
);

