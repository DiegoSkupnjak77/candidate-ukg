using Moq;
using NUnit.Framework;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Repositories;
using TraineeProgram.Domain.Services;
using TraineeProgram.Tests.Mocks;

namespace TraineeProgram.Tests.Service
{
    public class CandidateServiceTests
    {
        private Mock<ICandidateRepository> _mockedCandidateRepository;
        private CandidateService _candidateService;
        private IEnumerable<Candidate> _candidateList;
        private Candidate _candidateObj;

        [SetUp]
        public void Setup()
        {
            _mockedCandidateRepository = new Mock<ICandidateRepository>();
            _candidateList = CandidateMock.MockedCandidateList();
            _candidateObj = CandidateMock.MockedCandidateObj();
        }

        [Test]
        public async Task GetAllAsync_ExistingCandidates_ReturnsCandidateList()
        {
            _mockedCandidateRepository.Setup(x => x.GetAllAsync())
                .ReturnsAsync(_candidateList);
            _candidateService = new CandidateService(_mockedCandidateRepository.Object);
            var result = await _candidateService.GetAllAsync();
            Assert.That(_candidateList.Count(), Is.EqualTo(result.Count()));
        }

        [Test]
        public async Task GetByIdAsync_ExistingCandidate_ReturnsCandidate()
        {
            _mockedCandidateRepository.Setup(x => x.GetByIdAsync(1))
                .ReturnsAsync(_candidateObj);
            _candidateService = new CandidateService(_mockedCandidateRepository.Object);
            var result = await _candidateService.GetByIdAsync(1);
            Assert.That(result, Is.EqualTo(_candidateObj));
        }

        [Test]
        public async Task CreateCandidate_CreatesACandidate_ReturnsCandidate()
        {
            _mockedCandidateRepository.Setup(repo => repo.CreateAsync(It.IsAny<Candidate>())).
                ReturnsAsync(_candidateObj);
            _candidateService = new CandidateService(_mockedCandidateRepository.Object);
            var result = await _candidateService.CreateAsync(_candidateObj);
            Assert.That(result, Is.EqualTo(_candidateObj));
        }
    }
}