using TraineeProgram.Domain.Models;

namespace TraineeProgram.Domain.Repositories
{
    public interface IOfferLetterRepository
    {
        Task<IEnumerable<OfferLetter>> GetAllAsync();
        Task<OfferLetter> GetByIdAsync(int id);
        Task<OfferLetter> CreateAsync(OfferLetter offerLetter);
    }
}