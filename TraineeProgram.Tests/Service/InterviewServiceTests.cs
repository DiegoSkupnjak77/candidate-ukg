using Moq;
using NUnit.Framework;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Repositories;
using TraineeProgram.Domain.Services;
using TraineeProgram.Tests.Mocks;

namespace TraineeProgram.Tests.Service
{
    internal class InterviewServiceTests
    {
        private Mock<IInterviewRepository> _mockedInterviewRepository;
        private InterviewService _interviewService;
        private Interview _interviewObj;

        [SetUp]
        public void SetUp()
        {
            _mockedInterviewRepository = new Mock<IInterviewRepository>();
            _interviewObj = InterviewMock.InterviewObj();
        }

        [Test]
        public async Task CreateAsync_CreatesHrInterview_ReturnsInterview()
        {
            _mockedInterviewRepository.Setup(x => x.CreateAsync(It.IsAny<Interview>())).
                ReturnsAsync(_interviewObj);
            _interviewService = new InterviewService(_mockedInterviewRepository.Object);
            var result = await _interviewService.CreateAsync(_interviewObj);
            Assert.That(_interviewObj, Is.EqualTo(result));
        }
    }
}
