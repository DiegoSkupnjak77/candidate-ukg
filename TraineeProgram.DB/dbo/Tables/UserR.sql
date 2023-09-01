CREATE TABLE [dbo].[UserR] (
    [id]        INT             IDENTITY (1, 1) NOT NULL,
    [firstName] VARCHAR (30)    NOT NULL,
    [lastName]  VARCHAR (30)    NOT NULL,
    [email]     VARCHAR (60)    NOT NULL,
    [isActive]  BIT             NOT NULL,
    [userRole]  INT             NOT NULL,
    [Password]  NVARCHAR (200)  NOT NULL,
    [Photo]     VARBINARY (MAX) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [ctr_uniqueEmail] UNIQUE NONCLUSTERED ([email] ASC)
);











