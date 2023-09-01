using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBInterviewType
    {
        public DBInterviewType()
        {
            Interviews = new HashSet<DBInterview>();
            UserInterviewTypes = new HashSet<DBUserInterviewType>();
        }

        public int InterviewTypeId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<DBInterview> Interviews { get; set; }
        public virtual ICollection<DBUserInterviewType> UserInterviewTypes { get; set; }
    }
}
