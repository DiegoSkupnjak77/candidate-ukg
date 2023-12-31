﻿using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBCandidateLink
    {
        public int CandidateLinkId { get; set; }
        public string Link { get; set; } = null!;
        public int CandidateId { get; set; }
        public string LinkType { get; set; } = null!;

        public virtual DBCandidate Candidate { get; set; } = null!;
    }
}
