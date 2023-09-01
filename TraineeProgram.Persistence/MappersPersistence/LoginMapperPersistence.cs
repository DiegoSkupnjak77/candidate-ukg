using AutoMapper;
using TraineeProgram.Domain.Models;
using TraineeProgram.Persistence.DBEntities;

namespace TraineeProgram.Persistence.MappersPersistence
{
    public class LoginMapperPersistence
    {
        public class UserRMapperPersistence : Profile
        {
            public UserRMapperPersistence()
            {
                CreateMap<DBUserR, Login>();
            }
        }
        public class InvertedUserRMapper : Profile
        {
            public InvertedUserRMapper()
            {
                CreateMap<Login, DBUserR>();
            }
        }
    }
}
