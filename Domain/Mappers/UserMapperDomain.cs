using AutoMapper;
using TraineeProgram.Domain.Dto;
using TraineeProgram.Domain.Models;

namespace TraineeProgram.Domain.Mappers
{
    public class UserMapperDomain : Profile
    {
        public UserMapperDomain()
        {
            CreateMap<UserDto, User>();
        }
    }
    public class InvertedUserMapperDomain : Profile
    {
        public InvertedUserMapperDomain()
        {
            CreateMap<User, UserDto>();
        }
    }

    public class UserReadMapperDomain : Profile
    {
        public UserReadMapperDomain()
        {
            CreateMap<UserReadDto, User>();
        }
    }

    public class InvertedUserReadMapperDomain : Profile
    {
        public InvertedUserReadMapperDomain()
        {
            CreateMap<User, UserReadDto>();
        }
    }
}