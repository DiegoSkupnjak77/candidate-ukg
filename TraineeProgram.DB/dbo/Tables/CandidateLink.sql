CREATE TABLE [dbo].[CandidateLink] (
    [CandidateLinkId] INT           IDENTITY (1, 1) NOT NULL,
    [Link]            VARCHAR (200) NOT NULL,
    [CandidateId]     INT           NOT NULL,
    [LinkType]        VARCHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([CandidateLinkId] ASC),
    FOREIGN KEY ([CandidateId]) REFERENCES [dbo].[Candidate] ([CandidateId])
);

