using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBInterviewUser
    {
        public int InterviewUserId { get; set; }
        public int UserId { get; set; }
        public int InterviewId { get; set; }

        public virtual DBInterview Interview { get; set; } = null!;
        public virtual DBUserR User { get; set; } = null!;
    }
}
