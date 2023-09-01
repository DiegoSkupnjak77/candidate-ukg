using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Repositories;
using TraineeProgram.Persistence.DBEntities;
using static TraineeProgram.Domain.Exceptions.UserExceptions;

namespace TraineeProgram.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TraineeProgramDBContext _context;
        private readonly IMapper _mapper;

        public UserRepository(TraineeProgramDBContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            var user = await _context.UserRs.ToListAsync();
            return _mapper.Map<IEnumerable<User>>(user);
        }

        public async Task<User> CreateAsync(User newUser)
        {
            try
            {
                var password = newUser.Password;
                password = UserEncrypted.GetSHA256(newUser.Password);
                newUser.Password = password;
                var userToInsert = await _context.UserRs.AddAsync(_mapper.Map<DBUserR>(newUser));
                await _context.SaveChangesAsync();
                var UserSaved = await _context.UserRs.FirstOrDefaultAsync(u => u.Id == userToInsert.Entity.Id);
                return _mapper.Map<User>(UserSaved);
            }
            catch (Exception ex)
            {
                if (ex.InnerException is SqlException sqlException && sqlException.Number == 2627)
                    throw new DuplicateUserException("User already created");
                throw;
            }
        }

        public async Task<User> GetByIdAsync(int id)
        {
            var user = await _context.UserRs.FirstOrDefaultAsync(u => u.Id == id);
            return _mapper.Map<User>(user);
        }
    }
}