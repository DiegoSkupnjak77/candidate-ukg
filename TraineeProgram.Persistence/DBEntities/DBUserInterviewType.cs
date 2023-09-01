using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBUserInterviewType
    {
        public int UserInterviewTypeId { get; set; }
        public int InterviewTypeId { get; set; }
        public int UserId { get; set; }

        public virtual DBInterviewType InterviewType { get; set; } = null!;
        public virtual DBUserR User { get; set; } = null!;
    }
}
