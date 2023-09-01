using TraineeProgram.Domain.Models;

namespace TraineeProgram.Domain.Services.Interfaces
{
    public interface ILoginService
    {
        Task<User> LoginUser(Login userLogged);
    }
}