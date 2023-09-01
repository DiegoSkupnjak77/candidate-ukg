using TraineeProgram.Domain.Models;

namespace TraineeProgram.Domain.Services.Interfaces
{
    public interface IOfferLetterService
    {
        Task<IEnumerable<OfferLetter>> GetAllAsync();
        Task<OfferLetter> GetByIdAsync(int id);
        Task<OfferLetter> CreateAsync(OfferLetter offerLetter);
    }
}