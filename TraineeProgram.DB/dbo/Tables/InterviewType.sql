CREATE TABLE [dbo].[InterviewType] (
    [id]    INT          IDENTITY (1, 1) NOT NULL,
    [iType] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CHECK ([iType]='Offer Letter' OR [iType]='VP' OR [iType]='Manager' OR [iType]='Technical' OR [iType]='Cultural' OR [iType]='HR')
);

