using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBReference
    {
        public int ReferenceId { get; set; }
        public int CandidateId { get; set; }
        public int UserId { get; set; }
        public DateTime ReferenceDate { get; set; }
        public string? RelatedBy { get; set; }
        public string? Comments { get; set; }

        public virtual DBCandidate Candidate { get; set; } = null!;
        public virtual DBUserR User { get; set; } = null!;
    }
}
