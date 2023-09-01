using AutoMapper;
using TraineeProgram.Domain.Models;
using TraineeProgram.Persistence.DBEntities;

namespace TraineeProgram.Persistence.Mappers
{
    public class CandidateMapperPersistence : Profile
    {
        public CandidateMapperPersistence() 
        {
            CreateMap<DBCandidate,Candidate>();
        }
    }
    public class InvertedCandidateMapper : Profile
    {
        public InvertedCandidateMapper() 
        {
            CreateMap<Candidate, DBCandidate>();
        }
    }
    public class CandidateLinkMapperPersistence : Profile
    {
        public CandidateLinkMapperPersistence()
        {
            CreateMap<DBCandidateLink, Candidatelink>();
        }
    }
    public class InvertedCandidateLinkMapper : Profile
    {
        public InvertedCandidateLinkMapper()
        {
            CreateMap<Candidatelink, DBCandidateLink>();
        }
    }
}