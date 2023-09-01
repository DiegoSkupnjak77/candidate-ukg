CREATE TABLE [dbo].[Candidate] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [firstName]    VARCHAR (30)  NOT NULL,
    [middleName]   VARCHAR (30)  NULL,
    [lastName]     VARCHAR (30)  NOT NULL,
    [mobilePhone]  VARCHAR (30)  NOT NULL,
    [email]        VARCHAR (60)  NOT NULL,
    [photo]        VARCHAR (100) NULL,
    [coverLetter]  VARCHAR (500) NULL,
    [uploadResume] VARCHAR (500) NULL,
    [isActive]     BIT           NULL,
    [IdJobOpening] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [ctr_Email] UNIQUE NONCLUSTERED ([email] ASC)
);





