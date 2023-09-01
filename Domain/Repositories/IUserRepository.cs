using TraineeProgram.Domain.Models;

namespace TraineeProgram.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<User> CreateAsync(User user);
    }
}