CREATE TABLE [dbo].[HR] (
    [idInterview]    INT NOT NULL,
    [salaryExpected] INT NULL,
    PRIMARY KEY CLUSTERED ([idInterview] ASC),
    FOREIGN KEY ([idInterview]) REFERENCES [dbo].[interview] ([id])
);



