using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBCandidateSkill
    {
        public int CandidateSkillId { get; set; }
        public int SkillId { get; set; }
        public int CandidateId { get; set; }

        public virtual DBCandidate Candidate { get; set; } = null!;
        public virtual DBSkill Skill { get; set; } = null!;
    }
}
