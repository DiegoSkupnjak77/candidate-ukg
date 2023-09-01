using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBJobOpening
    {
        public DBJobOpening()
        {
            CandidateJobOpenings = new HashSet<DBCandidateJobOpening>();
            Interviews = new HashSet<DBInterview>();
        }

        public int JobOpeningId { get; set; }
        public int JobRoleId { get; set; }
        public int SeniorityId { get; set; }
        public int TeamId { get; set; }
        public int? OpenPositions { get; set; }
        public string JobTitle { get; set; } = null!;
        public string JobSummary { get; set; } = null!;
        public string? Link { get; set; }
        public int WorkHours { get; set; }

        public virtual DBJobRole JobRole { get; set; } = null!;
        public virtual DBSeniority Seniority { get; set; } = null!;
        public virtual DBTeam Team { get; set; } = null!;
        public virtual ICollection<DBCandidateJobOpening> CandidateJobOpenings { get; set; }
        public virtual ICollection<DBInterview> Interviews { get; set; }
    }
}
