using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBCandidate
    {
        public DBCandidate()
        {
            CandidateJobOpenings = new HashSet<DBCandidateJobOpening>();
            CandidateLinks = new HashSet<DBCandidateLink>();
            CandidateSkills = new HashSet<DBCandidateSkill>();
            Processes = new HashSet<DBProcess>();
            References = new HashSet<DBReference>();
        }

        public int CandidateId { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public string MobilePhone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Photo { get; set; }
        public string? CoverLetter { get; set; }
        public string? UploadResume { get; set; }
        public bool? IsActive { get; set; }
        public string Dni { get; set; } = null!;
        public string Address { get; set; } = null!;

        public virtual ICollection<DBCandidateJobOpening> CandidateJobOpenings { get; set; }
        public virtual ICollection<DBCandidateLink> CandidateLinks { get; set; }
        public virtual ICollection<DBCandidateSkill> CandidateSkills { get; set; }
        public virtual ICollection<DBProcess> Processes { get; set; }
        public virtual ICollection<DBReference> References { get; set; }
    }
}
