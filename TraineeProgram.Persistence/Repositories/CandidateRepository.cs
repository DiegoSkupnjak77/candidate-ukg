using AutoMapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TraineeProgram.Domain.Dto;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Repositories;
using TraineeProgram.Persistence.DBEntities;
using TraineeProgram.Persistence.MapDBInterviewTpInterviewType;
using static TraineeProgram.Domain.Exceptions.CandidateException;

namespace TraineeProgram.Persistence.Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly TraineeProgramDBContext _context;
        private readonly IMapper _mapper;

        public CandidateRepository(TraineeProgramDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Candidate>> GetAllAsync()
        {
            var candidates = await _context.Candidates.Where(c => c.IsActive== true)
                .Include(i => i.CandidateLinks).ToListAsync();

            return _mapper.Map<IEnumerable<Candidate>>(candidates);
        }

        public async Task<Candidate> GetByIdAsync(int id)
        {
            var candidate = await _context.Candidates.Include(i => i.CandidateLinks).FirstOrDefaultAsync(c => c.CandidateId == id);
            return _mapper.Map<Candidate>(candidate);
        }
        public async Task<IEnumerable<Interview>> GetInterviewByCandidateId(int id)
        {
            List<Interview> interviews = new List<Interview>();

            var interviewsFromDB = await _context.Interviews
                .ToListAsync();

            foreach (var i in interviewsFromDB)
            {
                var interviewType = MapDBInterviewToInterviewType.MapToInterviewType(i, _mapper);
                if (interviewType != null)
                {
                    interviews.Add(interviewType);
                }
            }
            return interviews;
        }

        public async Task<Candidate> CreateAsync(Candidate newCandidate)
        {
            try
            {
                var candidateToInsert = await _context.Candidates.AddAsync(_mapper.Map<DBCandidate>(newCandidate));
                await _context.SaveChangesAsync();
                var candidateSaved = await _context.Candidates.Include(i => i.CandidateLinks).
                    FirstOrDefaultAsync(c => c.CandidateId == candidateToInsert.Entity.CandidateId);
                return _mapper.Map<Candidate>(candidateSaved);
            }
            catch (Exception ex)
            {
                if (ex.InnerException is SqlException sqlException && sqlException.Number == 2627)
                    throw new DuplicateCandidateException("Candidate already created");

                throw;
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            bool ok = false;
            var candidateLogicRemov = await _context.Candidates.FirstOrDefaultAsync(c => c.CandidateId == id);
            if (candidateLogicRemov!=null)
            {
                candidateLogicRemov.IsActive=false;
                _context.Update(candidateLogicRemov);
                int afectedRows = _context.SaveChanges();
                ok= afectedRows>0;
            }
            return ok;
        }

        public async Task<Candidate> UpdateAsync(Candidate candidate)
        {
            var candidateUpdated = _context.Candidates.Update(_mapper.Map<DBCandidate>(candidate));

            var rowsAfected = await _context.SaveChangesAsync();
            var can = await _context.Candidates.FirstOrDefaultAsync(c => c.CandidateId == candidateUpdated.Entity.CandidateId);
            return rowsAfected >0 ? _mapper.Map<Candidate>(can) : null;
        }
        public async Task<IEnumerable<Candidate>> ListOfCandidates()
        {
            var candidates = await _context.Candidates.Where(c => c.IsActive == true && c.CandidateJobOpenings.Count>0 && c.Processes.Count()>0)
                .ToListAsync();
            return _mapper.Map<IEnumerable<Candidate>>(candidates);
        }
    }
}