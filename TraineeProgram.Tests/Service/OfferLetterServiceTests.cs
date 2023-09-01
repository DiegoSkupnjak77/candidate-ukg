using Moq;
using NUnit.Framework;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Repositories;
using TraineeProgram.Domain.Services;
using TraineeProgram.Tests.Mocks;

namespace TraineeProgram.Tests.Service
{
    public class tests
    {
        private Mock<IOfferLetterRepository> _mockedOfferLetterRepository;
        private OfferLetterService _offerLetterService;
        private IEnumerable<OfferLetter> _offerLetterList;
        private OfferLetter _offerLetterObj;

        [SetUp]
        public void Setup()
        {
            _mockedOfferLetterRepository = new Mock<IOfferLetterRepository>();
            _offerLetterList = OfferLetterMock.MockedOfferLetterList();
            _offerLetterObj = OfferLetterMock.MockedOfferLetterObj();
        }

        [Test]
        public async Task GetAllAsync_ExistingOfferLetter_ReturnsOfferLetterList()
        {
            _mockedOfferLetterRepository.Setup(repo => repo.GetAllAsync())
                .ReturnsAsync(_offerLetterList);
            _offerLetterService = new OfferLetterService(_mockedOfferLetterRepository.Object);
            var result = await _offerLetterService.GetAllAsync();
            Assert.AreEqual(_offerLetterList, result);
        }

        [Test]
        public async Task GetByIdAsync_ExistingOfferLetter_ReturnsOfferLetter()
        {
            _mockedOfferLetterRepository.Setup(repo => repo.GetByIdAsync(1))
                .ReturnsAsync(_offerLetterObj);
            _offerLetterService = new OfferLetterService(_mockedOfferLetterRepository.Object);
            var result = await _offerLetterService.GetByIdAsync(1);
            Assert.AreEqual(_offerLetterObj, result);
        }

        [Test]
        public async Task CreateAsync_CreateOfferLetter_ReturnsOfferLetter()
        {
            _mockedOfferLetterRepository.Setup(repo => repo.CreateAsync(It.IsAny<OfferLetter>())).
                ReturnsAsync(_offerLetterObj);
            _offerLetterService = new OfferLetterService(_mockedOfferLetterRepository.Object);
            var result = await _offerLetterService.CreateAsync(_offerLetterObj);
            Assert.AreEqual(_offerLetterObj.IdOfferLetter, result.IdOfferLetter);
            Assert.AreEqual(_offerLetterObj.Salary, result.Salary);
            Assert.AreEqual(_offerLetterObj.Status, result.Status);
            Assert.AreEqual(_offerLetterObj.IdUser, result.IdUser);
            Assert.AreEqual(_offerLetterObj.Contract, result.Contract);
            Assert.AreEqual(_offerLetterObj.IdJobOpening, result.IdJobOpening);
            Assert.AreEqual(_offerLetterObj.IdCandidate, result.IdCandidate);
        }
    }
}