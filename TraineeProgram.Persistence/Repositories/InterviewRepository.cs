using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Repositories;
using TraineeProgram.Persistence.DBEntities;
using TraineeProgram.Persistence.MapDBInterviewTpInterviewType;
using static TraineeProgram.Domain.Exceptions.InterviewException;

namespace TraineeProgram.Persistence.Repositories
{
    public class InterviewRepository : IInterviewRepository
    {
        private readonly TraineeProgramDBContext _context;
        private readonly IMapper _mapper;
        public InterviewRepository(TraineeProgramDBContext context, IMapper mapper)
        {
            _context=context;
            _mapper=mapper;
        }
        public async Task<IEnumerable<Interview>> GetAllAsync()
        {
            List<Interview> interviews = new List<Interview>();

            var interviewsFromDB = await _context.Interviews
                .ToListAsync();

            foreach (var i in interviewsFromDB)
            {
                var interviewType = MapDBInterviewToInterviewType.MapToInterviewType(i, _mapper);
                if (interviewType!=null)
                {
                    interviews.Add(interviewType);
                }
            }
            return interviews;
        }

        public async Task<Interview> CreateAsync(Interview interview)
        {
            try
            {
                var map = _mapper.Map<DBInterview>(interview);
                var interviewSaved = await _context.Interviews.AddAsync(map);
                await _context.SaveChangesAsync();
                var specificInterviewSaved = CreateASpecificInterview(interview, interviewSaved.Entity.InterviewId);
                return interview;
            }
            catch (Exception ex)
            {
                if (ex.InnerException is SqlException sqlException && sqlException.Number == 547)
                    throw new RelationForeignKeyException("job opening, candidate or user not exist");
                throw;
            }
        }
        public async Task<Interview> GetLastInterviewByCandidateIdAsync(int id)
        {
                var interviewFromDB = await _context.Interviews.OrderBy(i => i.InterviewId)
                .LastOrDefaultAsync();
                var interviewType = MapDBInterviewToInterviewType.MapToInterviewType(interviewFromDB, _mapper);
                return interviewType;
        }
        public async Task<Interview> CreateASpecificInterview(Interview interview, int lastInterviewId)
        {

            switch (interview)
            {
                //case Hr:
                //    Hr? hr = interview as Hr;
                //    hr.IdInterview= lastInterviewId;
                //    await _context.AddAsync(_mapper.Map<DBHr>(hr));
                //    await _context.SaveChangesAsync();
                //    return interview;

                //case Cultural:
                //    Cultural? cultural = interview as Cultural;
                //    cultural.IdInterview= lastInterviewId;
                //    await _context.AddAsync(_mapper.Map<DBCultural>(cultural));
                //    await _context.SaveChangesAsync();
                //    return interview;
                //case Technical:
                //    Technical? technical = interview as Technical;
                //    technical.IdInterview= lastInterviewId;
                //    await _context.AddAsync(_mapper.Map<DBTechnical>(technical));
                //    await _context.SaveChangesAsync();
                //    return interview;
                //case Manager:
                //    Manager? manager = interview as Manager;
                //    manager.IdInterview= lastInterviewId;
                //    await _context.AddAsync(_mapper.Map<DBManager>(manager));
                //    await _context.SaveChangesAsync();
                //    return interview;
                //case Vp:
                //    Vp? vp = interview as Vp;
                //    vp.IdInterview= lastInterviewId;
                //    await _context.AddAsync(_mapper.Map<DBVp>(vp));
                //    await _context.SaveChangesAsync();
                //    return interview;
                default:
                    return null;

            }
        }

    }
}