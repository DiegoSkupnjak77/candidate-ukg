using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Repositories;
using TraineeProgram.Domain.Services.Interfaces;
using static TraineeProgram.Domain.Exceptions.UserExceptions;

namespace TraineeProgram.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> CreateAsync(User newUser)
        {
            bool validData = ValidationData(newUser);
            bool validRol = ValidUserRoles(newUser.UserRole);
            if (validData && validRol)
                return await _userRepository.CreateAsync(newUser);
            if (validData)
            {
                throw new RolUserException("Rol numbers only can be 1/2/3");
            }
            throw new FieldRequiredException("You must all complete the fields");
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return  await _userRepository.GetByIdAsync(id);
        }

        private bool ValidationData(User newUser)
        {
            return !string.IsNullOrEmpty(newUser.FirstName) && !string.IsNullOrEmpty(newUser.LastName)
                && !string.IsNullOrEmpty(newUser.Email);
        }

        private bool ValidUserRoles(int rolNumber)
        {
            bool valid;
            switch (rolNumber)
            {
                case 1:
                case 2:
                case 3:
                    valid = true;
                    break;
                default:
                    valid = false;
                    break;
            }
            return valid;
        }
    }
}