using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeProgram.Domain.Models
{
    public class Hr : Interview
    {
        public int IdInterview { get; set; }
        public int? SalaryExpected { get; set; }
    }
}