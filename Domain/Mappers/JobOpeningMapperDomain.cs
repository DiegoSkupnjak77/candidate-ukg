using AutoMapper;
using TraineeProgram.Domain.Dto;
using TraineeProgram.Domain.Models;

namespace TraineeProgram.Domain.Mappers
{
    public class JobOpeningMapperDomain : Profile
    {
        public JobOpeningMapperDomain()
        {
            CreateMap<JobOpeningDto, JobOpening>();
        }
    }
    public class InvertedJobOpeningMapperDomain : Profile
    {
        public InvertedJobOpeningMapperDomain()
        {
            CreateMap<JobOpening, JobOpeningDto>();
        }
    }
    public class JobOpeningReadMapperDomain : Profile
    {
        public JobOpeningReadMapperDomain()
        {
            CreateMap<JobOpeningReadDto, JobOpening>();
        }
    }
    public class InvertedJobOpeningReadMapperDomain : Profile
    {
        public InvertedJobOpeningReadMapperDomain()
        {
            CreateMap<JobOpening, JobOpeningReadDto>();
        }
    }
}