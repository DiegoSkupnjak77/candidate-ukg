using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeProgram.Domain.Models
{
    public abstract class Interview
    {
        public int Id { get; set; }
        public string InterviewName { get; set; }
        public DateTime InterviewDate { get; set; }
        public string Feedback { get; set; }
        public bool IsApproved { get; set; }
        public string Reason { get; set; }
        public int IdCandidate { get; set; }
        public int IdJobOpening { get; set; }
        public int IdUser { get; set; }
    }
}