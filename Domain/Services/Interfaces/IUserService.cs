using TraineeProgram.Domain.Models;

namespace TraineeProgram.Domain.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<User> CreateAsync(User newUser);
    }
}