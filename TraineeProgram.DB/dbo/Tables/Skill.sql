CREATE TABLE [dbo].[Skill] (
    [SkillId]    INT           IDENTITY (1, 1) NOT NULL,
    [Name]       VARCHAR (200) NOT NULL,
    [IsLanguage] BIT           NOT NULL,
    [JobRoleId]  INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([SkillId] ASC),
    FOREIGN KEY ([JobRoleId]) REFERENCES [dbo].[JobRole] ([JobRoleId])
);

