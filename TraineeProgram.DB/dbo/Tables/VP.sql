CREATE TABLE [dbo].[VP] (
    [idInterview] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([idInterview] ASC),
    FOREIGN KEY ([idInterview]) REFERENCES [dbo].[Interview] ([id])
);

