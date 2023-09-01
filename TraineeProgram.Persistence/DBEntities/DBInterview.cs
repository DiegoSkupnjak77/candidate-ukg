using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBInterview
    {
        public DBInterview()
        {
            InterviewUsers = new HashSet<DBInterviewUser>();
        }

        public int InterviewId { get; set; }
        public int InterviewTypeId { get; set; }
        public DateTime InterviewDate { get; set; }
        public string? Feedback { get; set; }
        public bool IsApproved { get; set; }
        public int ProcessId { get; set; }
        public int JobOpeningId { get; set; }

        public virtual DBInterviewType InterviewType { get; set; } = null!;
        public virtual DBJobOpening JobOpening { get; set; } = null!;
        public virtual DBProcess Process { get; set; } = null!;
        public virtual ICollection<DBInterviewUser> InterviewUsers { get; set; }
    }
}
