using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBTeam
    {
        public DBTeam()
        {
            JobOpenings = new HashSet<DBJobOpening>();
            TeamSkills = new HashSet<DBTeamSkill>();
            UserRs = new HashSet<DBUserR>();
        }

        public int TeamId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<DBJobOpening> JobOpenings { get; set; }
        public virtual ICollection<DBTeamSkill> TeamSkills { get; set; }
        public virtual ICollection<DBUserR> UserRs { get; set; }
    }
}
