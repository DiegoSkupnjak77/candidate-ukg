using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBCandidateJobOpening
    {
        public int CandidateJobOpeningId { get; set; }
        public int CandidateId { get; set; }
        public int JobOpeningId { get; set; }
        public DateTime? PostulationDate { get; set; }

        public virtual DBCandidate Candidate { get; set; } = null!;
        public virtual DBJobOpening JobOpening { get; set; } = null!;
    }
}
