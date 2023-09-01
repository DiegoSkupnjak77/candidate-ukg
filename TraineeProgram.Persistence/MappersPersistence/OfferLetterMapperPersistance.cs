using AutoMapper;
using TraineeProgram.Domain.Models;
using TraineeProgram.Persistence.DBEntities;

namespace TraineeProgram.Persistence.MappersPersistence
{
    public class OfferLetterMapperPersistence : Profile
    {
        public OfferLetterMapperPersistence()
        {
            CreateMap<DBOfferLetter, OfferLetter>();
        }
    }
    public class InvertedOfferLetterMapperPersistence : Profile
    {
        public InvertedOfferLetterMapperPersistence()
        {
            CreateMap<OfferLetter, DBOfferLetter>();
        }
    }
}