using Moq;
using NUnit.Framework;
using TraineeProgram.Domain.Models;
using TraineeProgram.Domain.Repositories;
using TraineeProgram.Domain.Services;
using TraineeProgram.Tests.Mocks;

namespace TraineeProgram.Tests.Service
{
    public class UserServiceTests
    {
        private Mock<IUserRepository> _mockedUserRepository;
        private UserService _userService;
        private IEnumerable<User> _userList;
        private User _user;

        [SetUp]
        public void SetUp()
        {
            _mockedUserRepository = new Mock<IUserRepository>();
            _userList= UserMock.MockedUserList();
            _user= UserMock.MockedUserObj();
        }

        [Test]
        public async Task GetAllAsync_ExistingUser_ReturnsUserList()
        {
            _mockedUserRepository.Setup(repo => repo.GetAllAsync())
                .ReturnsAsync(_userList);

            _userService = new UserService(_mockedUserRepository.Object);

            var result = await _userService.GetAllAsync();

            Assert.AreEqual(_userList, result);
        }

        [Test]
        public async Task CreateUserAsync_ReturnsUser()
        {
            _mockedUserRepository.Setup(repo => repo.CreateAsync(It.IsAny<User>()))
                .ReturnsAsync(_user);

            _userService = new UserService(_mockedUserRepository.Object);

            var result = await _userService.CreateAsync(_user);

            Assert.AreEqual(_user.FirstName, result.FirstName);
            Assert.AreEqual(_user.LastName, result.LastName);
            Assert.AreEqual(_user.Email, result.Email);
            Assert.AreEqual(_user.Password, result.Password);
            Assert.AreEqual(_user.IsActive, result.IsActive);
            Assert.AreEqual(_user.UserRole, result.UserRole);
        }
    }
}