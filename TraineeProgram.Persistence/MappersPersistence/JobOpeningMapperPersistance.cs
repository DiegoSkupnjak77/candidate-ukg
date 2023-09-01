using AutoMapper;
using TraineeProgram.Domain.Models;
using TraineeProgram.Persistence.DBEntities;

namespace TraineeProgram.Persistence.MappersPersistence
{
    public class JobOpeningMapperPersistance : Profile
    {
        public JobOpeningMapperPersistance()
        {
            CreateMap<DBJobOpening, JobOpening>();
        }
    }
    public class InvertedJobOpeningMapper : Profile
    {
        public InvertedJobOpeningMapper()
        {
            CreateMap<JobOpening, DBJobOpening>();
        }
    }
}