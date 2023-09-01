CREATE TABLE [dbo].[Candidate_Links] (
    [link]        VARCHAR (200) NOT NULL,
    [idCandidate] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([idCandidate] ASC, [link] ASC),
    FOREIGN KEY ([idCandidate]) REFERENCES [dbo].[Candidate] ([id])
);

