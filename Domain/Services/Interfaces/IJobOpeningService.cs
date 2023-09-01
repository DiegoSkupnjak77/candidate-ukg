using TraineeProgram.Domain.Models;

namespace TraineeProgram.Domain.Services.Interfaces
{
    public interface IJobOpeningService
    {
        Task<IEnumerable<JobOpening>> GetAllAsync();
        Task<JobOpening> GetByIdAsync(int id);
        Task<JobOpening> CreateAsync(JobOpening newjobOpening);
    }
}