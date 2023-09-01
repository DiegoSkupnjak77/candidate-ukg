CREATE TABLE [dbo].[Interview] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [interviewName] VARCHAR (30)  NOT NULL,
    [interviewDate] DATE          NOT NULL,
    [feedback]      VARCHAR (500) NULL,
    [isApproved]    BIT           NOT NULL,
    [reason]        VARCHAR (100) NULL,
    [idCandidate]   INT           NULL,
    [idJobOpening]  INT           NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([idCandidate]) REFERENCES [dbo].[Candidate] ([id]),
    FOREIGN KEY ([idJobOpening]) REFERENCES [dbo].[JobOpening] ([id])
);

