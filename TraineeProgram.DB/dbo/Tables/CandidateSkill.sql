CREATE TABLE [dbo].[CandidateSkill] (
    [CandidateSkillId] INT IDENTITY (1, 1) NOT NULL,
    [SkillId]          INT NOT NULL,
    [CandidateId]      INT NOT NULL,
    PRIMARY KEY CLUSTERED ([CandidateSkillId] ASC),
    FOREIGN KEY ([CandidateId]) REFERENCES [dbo].[Candidate] ([CandidateId]),
    FOREIGN KEY ([SkillId]) REFERENCES [dbo].[Skill] ([SkillId]),
    UNIQUE NONCLUSTERED ([SkillId] ASC, [CandidateId] ASC)
);

