﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace TraineeProgram.Persistence.DBEntities
{
    public partial class DBOfferLetter
    {
        public int IdOfferLetter { get; set; }
        public string Contract { get; set; }
        public int Salary { get; set; }
        public string Status { get; set; }
        public int IdUser { get; set; }
        public int IdCandidate { get; set; }
        public int IdJobOpening { get; set; }

        public virtual DBCandidate IdCandidateNavigation { get; set; }
        public virtual DBJobOpening IdJobOpeningNavigation { get; set; }
        public virtual DBUserR IdUserNavigation { get; set; }
    }
}