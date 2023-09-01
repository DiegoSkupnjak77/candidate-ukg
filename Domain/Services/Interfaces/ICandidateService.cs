﻿using TraineeProgram.Domain.Dto;
using TraineeProgram.Domain.Models;

namespace TraineeProgram.Domain.Services.Interfaces
{
    public interface ICandidateService
    {
        Task<IEnumerable<Candidate>> GetAllAsync();
        Task<Candidate> CreateAsync(Candidate newCandidate);
        Task<Candidate> GetByIdAsync(int id);
        Task<IEnumerable<Interview>> GetInterviewByCandidateId(int id);
        Task<bool> DeleteAsync(int id);
        Task<Candidate> UpdateAsync(Candidate candidate); 
        Task<IEnumerable<Candidate>> ListOfCandidates();
    }
}