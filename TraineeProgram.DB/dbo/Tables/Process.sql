CREATE TABLE [dbo].[Process] (
    [ProcessId]     INT           IDENTITY (1, 1) NOT NULL,
    [ProcessDate]   DATE          NOT NULL,
    [CandidateId]   INT           NOT NULL,
    [IsActive]      BIT           NOT NULL,
    [ProcessStatus] VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([ProcessId] ASC),
    FOREIGN KEY ([CandidateId]) REFERENCES [dbo].[Candidate] ([CandidateId])
);

