using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBUserSkill
    {
        public int UserSkillId { get; set; }
        public int UserId { get; set; }
        public int SkillId { get; set; }

        public virtual DBSkill Skill { get; set; } = null!;
        public virtual DBUserR User { get; set; } = null!;
    }
}
