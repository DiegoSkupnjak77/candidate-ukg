CREATE TABLE [dbo].[TeamSkill] (
    [TeamSkillId] INT IDENTITY (1, 1) NOT NULL,
    [TeamId]      INT NOT NULL,
    [SkillId]     INT NOT NULL,
    PRIMARY KEY CLUSTERED ([TeamSkillId] ASC),
    FOREIGN KEY ([SkillId]) REFERENCES [dbo].[Skill] ([SkillId]),
    FOREIGN KEY ([TeamId]) REFERENCES [dbo].[Team] ([TeamId]),
    UNIQUE NONCLUSTERED ([TeamId] ASC, [SkillId] ASC)
);

