CREATE TABLE [dbo].[Candidate] (
    [CandidateId]  INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (30)  NOT NULL,
    [MiddleName]   VARCHAR (30)  NULL,
    [LastName]     VARCHAR (30)  NOT NULL,
    [MobilePhone]  VARCHAR (30)  NOT NULL,
    [Email]        VARCHAR (60)  NOT NULL,
    [Photo]        VARCHAR (100) NULL,
    [CoverLetter]  VARCHAR (500) NULL,
    [UploadResume] VARCHAR (500) NULL,
    [IsActive]     BIT           NULL,
    [Dni]          VARCHAR (50)  NOT NULL,
    [Address]      VARCHAR (200) NOT NULL,
    PRIMARY KEY CLUSTERED ([CandidateId] ASC),
    UNIQUE NONCLUSTERED ([Dni] ASC),
    UNIQUE NONCLUSTERED ([Email] ASC)
);







