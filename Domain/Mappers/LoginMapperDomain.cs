using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineeProgram.Domain.Dto;
using TraineeProgram.Domain.Models;

namespace TraineeProgram.Domain.Mappers
{
    public class LoginMapperDomain : Profile
    {
        public LoginMapperDomain()
        {
            CreateMap<LoginDto, Login>();
        }
    }
    public class InvertedLoginMapperDomain : Profile
    {
        public InvertedLoginMapperDomain()
        {
            CreateMap<Login, LoginDto>();
        }
    }

    public class LoginReadMapperDomain : Profile
    {
        public LoginReadMapperDomain()
        {
            CreateMap<LoginReadDto, Login>();
        }
    }

    public class InvertedLoginReadMapperDomain : Profile
    {
        public InvertedLoginReadMapperDomain()
        {
            CreateMap<Login, LoginReadDto>();
        }
    }
}
