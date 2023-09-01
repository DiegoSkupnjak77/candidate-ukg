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
    public class InterviewMapperDomain : Profile
    {
        public InterviewMapperDomain()
        {
            CreateMap<InterviewDto, Hr>()
                .ForMember(dest => dest.SalaryExpected, opt => opt.MapFrom(src => src.HrDto.SalaryExpected));
            CreateMap<InterviewDto, Cultural>();
            CreateMap<InterviewDto, Technical>()
                .ForMember(dest => dest.CandidateLevel, opt => opt.MapFrom(src => src.TechnicalDto.CandidateLevel));
            CreateMap<InterviewDto, Manager>();
            CreateMap<InterviewDto, Vp>();
        }
    }
    public class InvertedInterviewMapperDomain : Profile
    {
        public InvertedInterviewMapperDomain()
        {
            CreateMap<Hr, InterviewDto>()
                 .ForMember(dest => dest.HrDto, opt => opt.MapFrom(src => src));
            CreateMap<Cultural, InterviewDto>();
            CreateMap<Technical, InterviewDto>()
                .ForMember(dest => dest.TechnicalDto, opt => opt.MapFrom(src => src));
            CreateMap<Manager, InterviewDto>();
            CreateMap<Vp, InterviewDto>();
        }
    }
    public class InterviewReadMapperDomain : Profile
    {
        public InterviewReadMapperDomain()
        {
            CreateMap<InterviewReadDto, Hr>();
            CreateMap<HrReadDto, Hr>();

            CreateMap<InterviewReadDto, Cultural>();
            CreateMap<CulturalReadDto, Cultural>();

            CreateMap<InterviewReadDto, Technical>();
            CreateMap<TechnicalReadDto, Technical>();

            CreateMap<InterviewReadDto, Manager>();
            CreateMap<ManagerReadDto, Manager>();
            
            CreateMap<InterviewReadDto, Vp>();
            CreateMap<VpReadDto, Vp>();
        }
    }
    public class InvertedInterviewReadMapperDomain : Profile
    {
        public InvertedInterviewReadMapperDomain()
        {

            CreateMap<Hr, InterviewReadDto>()
                 .ForMember(dest => dest.HrDto, opt => opt.MapFrom(src => src)); ;
            CreateMap<Hr, HrReadDto>();

            CreateMap<Cultural, InterviewReadDto>()
                 .ForMember(dest => dest.CulturalDto, opt => opt.MapFrom(src => src)); ;
            CreateMap<Cultural, CulturalReadDto>();
            
            CreateMap<Technical, InterviewReadDto>()
                 .ForMember(dest => dest.TechnicalReadDto, opt => opt.MapFrom(src => src)); ;
            CreateMap<Technical, TechnicalReadDto>();

            CreateMap<Manager, InterviewReadDto>()
                 .ForMember(dest => dest.ManagerReadDto, opt => opt.MapFrom(src => src)); ;
            CreateMap<Manager, ManagerReadDto>();
            
            CreateMap<Vp, InterviewReadDto>()
                 .ForMember(dest => dest.VpReadDto, opt => opt.MapFrom(src => src)); ;
            CreateMap<Vp, VpReadDto>();
        }
    }
}