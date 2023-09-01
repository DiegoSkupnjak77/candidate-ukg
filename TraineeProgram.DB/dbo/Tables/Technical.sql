CREATE TABLE [dbo].[Technical] (
    [idInterview]    INT          NOT NULL,
    [candidateLevel] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([idInterview] ASC),
    FOREIGN KEY ([idInterview]) REFERENCES [dbo].[Interview] ([id])
);

