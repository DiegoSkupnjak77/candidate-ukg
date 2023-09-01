using TraineeProgram.Domain.Dto;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Repositories;
using TraineeProgram.Domain.Services.Interfaces;
using static TraineeProgram.Domain.Exceptions.CandidateException;

namespace TraineeProgram.Domain.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly ICandidateRepository _candidateRepository;
        public CandidateService(ICandidateRepository candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }
        public async Task<Candidate> CreateAsync(Candidate newCandidate)
        {
            if (ValidationData(newCandidate))
                return await _candidateRepository.CreateAsync(newCandidate);
            else
                throw new FieldRequiredException("There are empty fields");
        }

        private bool ValidationData(Candidate newCandidate)
        {
            return !string.IsNullOrEmpty(newCandidate.FirstName) && !string.IsNullOrEmpty(newCandidate.LastName)
                && !string.IsNullOrEmpty(newCandidate.Email) && !string.IsNullOrEmpty(newCandidate.MobilePhone);
        }

        public async Task<IEnumerable<Candidate>> GetAllAsync()
        {
            return await _candidateRepository.GetAllAsync();
        }

        public async Task<Candidate> GetByIdAsync(int id)
        {
            return await _candidateRepository.GetByIdAsync(id);
        }
        public async Task<IEnumerable<Interview>> GetInterviewByCandidateId(int id)
        {
            return await _candidateRepository.GetInterviewByCandidateId(id);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _candidateRepository.DeleteAsync(id);
        }

        public async Task<Candidate> UpdateAsync(Candidate candidate)
        {
            return await _candidateRepository.UpdateAsync(candidate);
        }

        public async Task<IEnumerable<Candidate>> ListOfCandidates()
        {
            return await _candidateRepository.ListOfCandidates();

        }
    }
}