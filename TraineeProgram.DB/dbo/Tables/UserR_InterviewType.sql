CREATE TABLE [dbo].[UserR_InterviewType] (
    [idType]  INT NOT NULL,
    [idUserR] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([idType] ASC, [idUserR] ASC),
    FOREIGN KEY ([idType]) REFERENCES [dbo].[InterviewType] ([id]),
    FOREIGN KEY ([idUserR]) REFERENCES [dbo].[UserR] ([id])
);

