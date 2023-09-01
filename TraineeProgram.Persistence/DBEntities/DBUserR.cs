using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBUserR
    {
        public DBUserR()
        {
            InterviewUsers = new HashSet<DBInterviewUser>();
            References = new HashSet<DBReference>();
            UserInterviewTypes = new HashSet<DBUserInterviewType>();
            UserSkills = new HashSet<DBUserSkill>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool IsActive { get; set; }
        public int JobRoleId { get; set; }
        public int SeniorityId { get; set; }
        public byte[]? Photo { get; set; }
        public int TeamId { get; set; }

        public virtual DBJobRole JobRole { get; set; } = null!;
        public virtual DBSeniority Seniority { get; set; } = null!;
        public virtual DBTeam Team { get; set; } = null!;
        public virtual ICollection<DBInterviewUser> InterviewUsers { get; set; }
        public virtual ICollection<DBReference> References { get; set; }
        public virtual ICollection<DBUserInterviewType> UserInterviewTypes { get; set; }
        public virtual ICollection<DBUserSkill> UserSkills { get; set; }
    }
}
