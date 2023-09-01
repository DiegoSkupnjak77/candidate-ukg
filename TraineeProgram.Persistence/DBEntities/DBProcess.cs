using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBProcess
    {
        public DBProcess()
        {
            Interviews = new HashSet<DBInterview>();
        }

        public int ProcessId { get; set; }
        public DateTime ProcessDate { get; set; }
        public int CandidateId { get; set; }
        public bool IsActive { get; set; }
        public string ProcessStatus { get; set; } = null!;

        public virtual DBCandidate Candidate { get; set; } = null!;
        public virtual ICollection<DBInterview> Interviews { get; set; }
    }
}
