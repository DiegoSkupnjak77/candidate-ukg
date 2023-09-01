using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Repositories;
using TraineeProgram.Domain.Services.Interfaces;
using static TraineeProgram.Domain.Exceptions.OfferLetterException;

namespace TraineeProgram.Domain.Services
{
    public class OfferLetterService : IOfferLetterService
    {
        private readonly IOfferLetterRepository _offerLetterRepository;

        public OfferLetterService(IOfferLetterRepository offerLetterRepository)
        {
            _offerLetterRepository = offerLetterRepository;
        }

        //public async Task<IEnumerable<OfferLetter>> GetAllAsync()
        //{
        //    return await _offerLetterRepository.GetAllAsync();
        //}

        //public async Task<OfferLetter> GetByIdAsync(int id)
        //{
        //    return await _offerLetterRepository.GetByIdAsync(id);
        //}
        //public async Task<OfferLetter> CreateAsync(OfferLetter offerLetter)
        //{
        //    if (ValidationDataService(offerLetter))
        //        return await _offerLetterRepository.CreateAsync(offerLetter);
        //    else
        //        throw new FieldRequiredException("There are empty fields");
        //}

        private bool ValidationDataService(OfferLetter offerLetter)
        {
            return !string.IsNullOrEmpty(offerLetter.Contract) && !string.IsNullOrEmpty(offerLetter.Status);
        }
    }
}