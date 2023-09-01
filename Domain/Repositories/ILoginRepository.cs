using TraineeProgram.Domain.Models;

namespace TraineeProgram.Domain.Repositories
{
    public interface ILoginRepository
    {
        Task<User> LoginUser(Login userLogged);
    }
}
