using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Repositories;
using TraineeProgram.Persistence.DBEntities;

namespace TraineeProgram.Persistence.Repositories
{
    public class JobOpeningRepository : IJobOpeningRepository
    {
        private readonly TraineeProgramDBContext _context;
        private readonly IMapper _mapper;

        public JobOpeningRepository(TraineeProgramDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<JobOpening>> GetAllAsync()
        {
            var jobOpening = await _context.JobOpenings.ToListAsync();
            return _mapper.Map<IEnumerable<JobOpening>>(jobOpening);
        }

        public async Task<JobOpening> GetByIdAsync(int id)
        {
            var jobOpening = await _context.JobOpenings.FirstOrDefaultAsync(c => c.Id == id);
            return _mapper.Map<JobOpening>(jobOpening);
        }

        public async Task<JobOpening> CreateAsync(JobOpening jobOpening)
        {
            var jobOpeningToInsert = await _context.JobOpenings.AddAsync(_mapper.Map<DBJobOpening>(jobOpening));
            await _context.SaveChangesAsync();
            var jobOpeningSaved = await _context.JobOpenings.FirstOrDefaultAsync(c => c.Id == jobOpeningToInsert.Entity.Id);
            return _mapper.Map<JobOpening>(jobOpeningSaved);
        }
    }
}