using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineeProgram.Domain.Models;

namespace TraineeProgram.Domain.Repositories
{
    public interface IInterviewRepository
    {
        Task<IEnumerable<Interview>> GetAllAsync();
        Task<Interview> CreateAsync(Interview newHrInterview);
        Task<Interview> GetLastInterviewByCandidateIdAsync(int id);  
    }
}