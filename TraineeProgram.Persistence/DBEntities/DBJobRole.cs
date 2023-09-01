using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBJobRole
    {
        public DBJobRole()
        {
            JobOpenings = new HashSet<DBJobOpening>();
            Skills = new HashSet<DBSkill>();
            UserRs = new HashSet<DBUserR>();
        }

        public int JobRoleId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<DBJobOpening> JobOpenings { get; set; }
        public virtual ICollection<DBSkill> Skills { get; set; }
        public virtual ICollection<DBUserR> UserRs { get; set; }
    }
}
