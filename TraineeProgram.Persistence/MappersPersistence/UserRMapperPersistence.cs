using AutoMapper;
using TraineeProgram.Domain.Models;
using TraineeProgram.Persistence.DBEntities;

namespace TraineeProgram.Persistence.MappersPersistence
{
    internal class UserRMapperPersistence : Profile
    {
        public UserRMapperPersistence()
        {
            CreateMap<DBUserR, User>();
        }
    }
    public class InvertedUserRMapper : Profile
    {
        public InvertedUserRMapper()
        {
            CreateMap<User, DBUserR>();
        }
    }
}