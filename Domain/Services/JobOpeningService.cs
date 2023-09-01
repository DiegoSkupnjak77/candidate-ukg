using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Repositories;
using TraineeProgram.Domain.Services.Interfaces;
using static TraineeProgram.Domain.Exceptions.JobOpeningException;

namespace TraineeProgram.Domain.Services
{
    public class JobOpeningService : IJobOpeningService
    {
        private readonly IJobOpeningRepository _jobOpeningRepository;

        public JobOpeningService(IJobOpeningRepository jobOpeningRepository)
        {
            _jobOpeningRepository = jobOpeningRepository;
        }

        public async Task<IEnumerable<JobOpening>> GetAllAsync()
        {
            return await _jobOpeningRepository.GetAllAsync();
        }

        public async Task<JobOpening> GetByIdAsync(int id)
        {
            return await _jobOpeningRepository.GetByIdAsync(id);
        }
        public async Task<JobOpening> CreateAsync(JobOpening jobOpening)
        {
            if (ValidationData(jobOpening))
                return await _jobOpeningRepository.CreateAsync(jobOpening);
            else
                throw new FieldRequiredException("There are empty fields");
        }

        private bool ValidationData(JobOpening jobOpening)
        {
            return !string.IsNullOrEmpty(jobOpening.Position) && !string.IsNullOrEmpty(jobOpening.JobTitle)
                && !string.IsNullOrEmpty(jobOpening.JobSummary);
        }
    }
}