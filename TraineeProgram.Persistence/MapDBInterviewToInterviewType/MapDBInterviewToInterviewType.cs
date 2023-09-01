using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineeProgram.Domain.Models;
using TraineeProgram.Persistence.DBEntities;

namespace TraineeProgram.Persistence.MapDBInterviewTpInterviewType
{
    public static class MapDBInterviewToInterviewType
    {
        public static Interview MapToInterviewType(DBInterview dBInterview, IMapper _mapper)
        {
            //if(dBInterview.Hr!=null) return  _mapper.Map<Hr>(dBInterview);
            //if(dBInterview.Cultural!=null) return  _mapper.Map<Cultural>(dBInterview);
            //if(dBInterview.Technical!=null) return _mapper.Map<Technical>(dBInterview);
            //if(dBInterview.Manager!=null) return _mapper.Map<Manager>(dBInterview);
            //if(dBInterview.Vp!=null) return  _mapper.Map<Vp>(dBInterview);

            return null;
        }
    }
}