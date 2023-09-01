using AutoMapper;
using TraineeProgram.Domain.Dto;
using TraineeProgram.Domain.Models;

namespace TraineeProgram.Domain.Mappers
{
    public class CandidateMapperDomain : Profile
    {
        public CandidateMapperDomain()
        {
            CreateMap<CandidateDto, Candidate>();
        }
    }
    public class InvertedCandidateMapperDomain : Profile
    {
        public InvertedCandidateMapperDomain()
        {
            CreateMap<Candidate, CandidateDto>();
        }
    }

    public class CandidateReadMapperDomain : Profile
    {
        public CandidateReadMapperDomain()

        {
            CreateMap<CandidateReadDto, Candidate>();
        }
    }

    public class InvertedCandidateReadMapperDomain : Profile
    {
        public InvertedCandidateReadMapperDomain()

        {
            CreateMap<Candidate, CandidateReadDto>();
        }
    }

    public class CandidateLinkMapperDomain : Profile
    {
        public CandidateLinkMapperDomain()
        {
            CreateMap<CandidatelinkDto, Candidatelink>();
        }
    }
    public class InvertedCandidateLinkMapperDomain : Profile
    {
        public InvertedCandidateLinkMapperDomain()
        {
            CreateMap<Candidatelink, CandidatelinkDto>();
        }
    }
}