CREATE TABLE [dbo].[OfferLetter] (
    [idOfferLetter] INT           IDENTITY (1, 1) NOT NULL,
    [_contract]     VARCHAR (500) NOT NULL,
    [salary]        INT           NOT NULL,
    [status]        VARCHAR (8)   NOT NULL,
    [idUser]        INT           NOT NULL,
    [idCandidate]   INT           NOT NULL,
    [idJobOpening]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([idOfferLetter] ASC),
    FOREIGN KEY ([idCandidate]) REFERENCES [dbo].[Candidate] ([id]),
    FOREIGN KEY ([idJobOpening]) REFERENCES [dbo].[JobOpening] ([id]),
    FOREIGN KEY ([idUser]) REFERENCES [dbo].[UserR] ([id])
);

