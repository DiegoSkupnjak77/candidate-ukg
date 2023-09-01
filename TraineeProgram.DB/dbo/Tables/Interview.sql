CREATE TABLE [dbo].[interview] (
    [id]            INT            IDENTITY (1, 1) NOT NULL,
    [interviewName] VARCHAR (30)   NOT NULL,
    [interviewDate] DATE           NOT NULL,
    [feedBack]      VARCHAR (1000) NULL,
    [isApproved]    BIT            NOT NULL,
    [reason]        VARCHAR (200)  NULL,
    [idCandidate]   INT            NOT NULL,
    [idJobOpening]  INT            NOT NULL,
    [idUser]        INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([idCandidate]) REFERENCES [dbo].[Candidate] ([id]),
    FOREIGN KEY ([idJobOpening]) REFERENCES [dbo].[JobOpening] ([id]),
    FOREIGN KEY ([idUser]) REFERENCES [dbo].[UserR] ([id])
);







