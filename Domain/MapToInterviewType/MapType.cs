using AutoMapper;
using TraineeProgram.Domain.Dto;
using TraineeProgram.Domain.Mappers;
using TraineeProgram.Domain.Models;

namespace TraineeProgram.Domain.MapToInterviewType
{
    public static class MapType 
    {
        public static Interview MapToInterviewType(InterviewDto dto,IMapper _mapper) {
            Interview mapInterview;
            switch (dto.TypeInterview) {
               
                case (InterviewDto.IType)1:
                   return mapInterview= _mapper.Map<Hr>(dto);
                case (InterviewDto.IType)2:
                   return mapInterview= _mapper.Map<Cultural>(dto);
                case (InterviewDto.IType)3:
                   return mapInterview= _mapper.Map<Technical>(dto);
                case (InterviewDto.IType)4:
                   return mapInterview= _mapper.Map<Manager>(dto);
                case (InterviewDto.IType)5:
                   return mapInterview= _mapper.Map<Vp>(dto);
                default:
                    return null;
            }
        }
    }
}