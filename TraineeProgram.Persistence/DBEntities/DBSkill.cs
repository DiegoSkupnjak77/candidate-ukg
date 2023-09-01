using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBSkill
    {
        public DBSkill()
        {
            CandidateSkills = new HashSet<DBCandidateSkill>();
            TeamSkills = new HashSet<DBTeamSkill>();
            UserSkills = new HashSet<DBUserSkill>();
        }

        public int SkillId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsLanguage { get; set; }
        public int JobRoleId { get; set; }

        public virtual DBJobRole JobRole { get; set; } = null!;
        public virtual ICollection<DBCandidateSkill> CandidateSkills { get; set; }
        public virtual ICollection<DBTeamSkill> TeamSkills { get; set; }
        public virtual ICollection<DBUserSkill> UserSkills { get; set; }
    }
}
