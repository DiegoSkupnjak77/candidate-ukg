using AutoMapper;
using TraineeProgram.Domain.Dto;
using TraineeProgram.Domain.Models;

namespace TraineeProgram.Domain.Mappers
{
    public class OfferLetterMapperDomain : Profile
    {
        public OfferLetterMapperDomain()
        {
            CreateMap<OfferLetterDto, OfferLetter>();
        }
    }
    public class InvertedOfferLetterMapperDomain : Profile
    {
        public InvertedOfferLetterMapperDomain()
        {
            CreateMap<OfferLetter, OfferLetterDto>();
        }
    }
    public class OfferLetterReadMapperDomain : Profile
    {
        public OfferLetterReadMapperDomain()
        {
            CreateMap<OfferLetterReadDto, OfferLetter>();
        }
    }
    public class InvertedOfferLetterReadMapperDomain : Profile
    {
        public InvertedOfferLetterReadMapperDomain()
        {
            CreateMap<OfferLetter, OfferLetterReadDto>();
        }
    }
}