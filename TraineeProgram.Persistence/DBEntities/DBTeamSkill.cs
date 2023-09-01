using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBTeamSkill
    {
        public int TeamSkillId { get; set; }
        public int TeamId { get; set; }
        public int SkillId { get; set; }

        public virtual DBSkill Skill { get; set; } = null!;
        public virtual DBTeam Team { get; set; } = null!;
    }
}
