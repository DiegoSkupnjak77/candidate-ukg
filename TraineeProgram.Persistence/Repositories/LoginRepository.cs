using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TraineeProgram.Domain.Exceptions;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Repositories;
using TraineeProgram.Persistence.DBEntities;

namespace TraineeProgram.Persistence.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly TraineeProgramDBContext _context;
        private readonly IMapper _mapper;

        public LoginRepository(TraineeProgramDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<User> LoginUser(Login userLogged)
        {
            var result = await _context.UserRs.FirstOrDefaultAsync(c => c.Email == userLogged.UserName);
            if (result == null)
            {
                throw new WrongCredentialsException("Wrong credentials");
            }
            var encryptedPassword = UserEncrypted.GetSHA256(userLogged.Password);

            return _mapper.Map<User>(result);

            throw new WrongCredentialsException("Wrong credentials");
        }
    }
}