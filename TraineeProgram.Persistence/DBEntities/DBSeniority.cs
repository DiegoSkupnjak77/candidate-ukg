using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBSeniority
    {
        public DBSeniority()
        {
            JobOpenings = new HashSet<DBJobOpening>();
            UserRs = new HashSet<DBUserR>();
        }

        public int SeniorityId { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<DBJobOpening> JobOpenings { get; set; }
        public virtual ICollection<DBUserR> UserRs { get; set; }
    }
}
