using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineeProgram.Domain.Models;
using TraineeProgram.Persistence.DBEntities;

namespace TraineeProgram.Persistence.MappersPersistence
{
    public class InterviewMapperPersistence : Profile
    {
        public InterviewMapperPersistence()
        {
            //CreateMap<DBInterview, Hr>()
            //   .ForMember(dest => dest.IdInterview, opt => opt.MapFrom(src => src.Id))
            //   .ForMember(dest => dest.SalaryExpected, opt => opt.MapFrom(src => src.Hr.SalaryExpected));
            //CreateMap<DBHr, Hr>();

            //CreateMap<DBInterview, Cultural>()
            //   .ForMember(dest => dest.IdInterview, opt => opt.MapFrom(src => src.Id));
            //CreateMap<DBCultural, Cultural>();

            //CreateMap<DBInterview, Technical>()
            // .ForMember(dest => dest.IdInterview, opt => opt.MapFrom(src => src.Id))
            // .ForMember(dest => dest.CandidateLevel, opt => opt.MapFrom(src => src.Technical.CandidateLevel));
            //CreateMap<DBTechnical, Technical>();

            //CreateMap<DBInterview, Manager>()
            //     .ForMember(dest => dest.IdInterview, opt => opt.MapFrom(src => src.Id));
            //CreateMap<DBManager, Manager>();

            //CreateMap<DBInterview, Vp>()
            //    .ForMember(dest => dest.IdInterview, opt => opt.MapFrom(src => src.Id));
            //CreateMap<DBVp, Vp>();
        }
    }
    public class InvertedInterviewMapper : Profile
    {
        public InvertedInterviewMapper()
        {
            //CreateMap<Hr, DBInterview>();
            //CreateMap<Hr, DBHr>();

            //CreateMap<Cultural, DBInterview>();
            //CreateMap<Cultural, DBCultural>();

            //CreateMap<Technical, DBInterview>();
            //CreateMap<Technical, DBTechnical>();

            //CreateMap<Manager, DBInterview>();
            //CreateMap<Manager, DBManager>();

            //CreateMap<Vp, DBInterview>();
            //CreateMap<Vp, DBVp>();
        }
    }
}