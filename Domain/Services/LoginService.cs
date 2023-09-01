using TraineeProgram.Domain.Exceptions;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Repositories;
using TraineeProgram.Domain.Services.Interfaces;

namespace TraineeProgram.Domain.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        
        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public Task<User> LoginUser(Login userLogged)
        {
            if (ValidationData(userLogged))
            {
                return _loginRepository.LoginUser(userLogged);
            }
            throw new FieldRequiredException("You must complete all the fields");
        }

        private bool ValidationData(Login userLogged)
        {
            return !string.IsNullOrEmpty(userLogged.UserName) && !string.IsNullOrEmpty(userLogged.Password); 
        }
    }
}