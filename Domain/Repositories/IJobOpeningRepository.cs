using TraineeProgram.Domain.Models;

namespace TraineeProgram.Domain.Repositories
{
    public interface IJobOpeningRepository
    {
        Task<IEnumerable<JobOpening>> GetAllAsync();
        Task<JobOpening> GetByIdAsync(int id);
        Task<JobOpening> CreateAsync(JobOpening jobOpening);
    }
}