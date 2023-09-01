CREATE TABLE [dbo].[UserSkill] (
    [UserSkillId] INT IDENTITY (1, 1) NOT NULL,
    [UserId]      INT NOT NULL,
    [SkillId]     INT NOT NULL,
    PRIMARY KEY CLUSTERED ([UserSkillId] ASC),
    FOREIGN KEY ([SkillId]) REFERENCES [dbo].[Skill] ([SkillId]),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[UserR] ([UserId]),
    UNIQUE NONCLUSTERED ([UserId] ASC, [SkillId] ASC)
);

