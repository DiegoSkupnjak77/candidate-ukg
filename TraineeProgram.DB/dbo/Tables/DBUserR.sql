CREATE TABLE [dbo].[UserR] (
    [id]        INT          IDENTITY (1, 1) NOT NULL,
    [firstName] VARCHAR (30) NOT NULL,
    [lastName]  VARCHAR (30) NOT NULL,
    [email]     VARCHAR (60) NOT NULL,
    [isActive]  BIT          NOT NULL,
    [userRole]  INT          NOT NULL,
    [Password] VARCHAR(20) NOT NULL, 
    PRIMARY KEY CLUSTERED ([id] ASC)
);

