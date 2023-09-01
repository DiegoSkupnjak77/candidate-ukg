using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Repositories;
using TraineeProgram.Domain.Services.Interfaces;

namespace TraineeProgram.Domain.Services
{
    public class InterviewService : IInterviewService
    {
        private readonly IInterviewRepository _iInterviewRepository;

        public InterviewService(IInterviewRepository interview)
        {
            _iInterviewRepository = interview;  
        }
        public async Task<IEnumerable<Interview>> GetAllAsync()
        {
            return await _iInterviewRepository.GetAllAsync();
        }
        public async Task<Interview> CreateAsync(Interview interview)
        {
            return await _iInterviewRepository.CreateAsync(interview);
        }

        public async Task<Interview> GetLastInterviewByCandidateIdAsync(int id)
        {
            return await _iInterviewRepository.GetLastInterviewByCandidateIdAsync(id);
        }
    }
}
