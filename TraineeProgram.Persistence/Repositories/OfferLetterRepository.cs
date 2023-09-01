using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Repositories;
using TraineeProgram.Persistence.DBEntities;
using static TraineeProgram.Domain.Exceptions.OfferLetterException;

namespace TraineeProgram.Persistence.Repositories
{
    public class OfferLetterRepository : IOfferLetterRepository
    {
        private readonly TraineeProgramDBContext _context;
        private readonly IMapper _mapper;

        public OfferLetterRepository(TraineeProgramDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OfferLetter>> GetAllAsync()
        {
            var offerLetter = await _context.OfferLetters.ToListAsync();
            return _mapper.Map<IEnumerable<OfferLetter>>(offerLetter);
        }

        public async Task<OfferLetter> GetByIdAsync(int id)
        {
            var offerLetter = await _context.OfferLetters.FirstOrDefaultAsync(c => c.IdOfferLetter == id);
            return _mapper.Map<OfferLetter>(offerLetter);
        }

        public async Task<OfferLetter> CreateAsync(OfferLetter offerLetter)
        {
            if (ValidationDataPersistence(offerLetter.IdUser, offerLetter.IdCandidate, offerLetter.IdJobOpening))
            {
                var offerLetterToInsert = await _context.OfferLetters.AddAsync(_mapper.Map<DBOfferLetter>(offerLetter));
                await _context.SaveChangesAsync();
                var offerLetterSaved = await _context.OfferLetters.FirstOrDefaultAsync(c => c.IdOfferLetter == offerLetterToInsert.Entity.IdOfferLetter);
                return _mapper.Map<OfferLetter>(offerLetterSaved);
            }
            else
                throw new EntityDoesntExistException("You need a Candidate/User/JobOpening existing");
        }

        private bool ValidationDataPersistence(int idUser, int idCandidate, int idJobOpening)
        {
            var UserOfferLetter = _context.UserRs.FirstOrDefault(c => c.Id == idUser);
            var CandidateOfferLetter = _context.Candidates.FirstOrDefault(c => c.Id == idCandidate);
            var JobOpeningOfferLetter = _context.JobOpenings.FirstOrDefault(c => c.Id == idJobOpening);
            return UserOfferLetter != null && CandidateOfferLetter != null && JobOpeningOfferLetter != null;

        }
    }
}