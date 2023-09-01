using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineeProgram.Domain.Models;

namespace TraineeProgram.Tests.Mocks
{
    public static class UserMock
    {
        public static IEnumerable<User> MockedUserList() => new List<User>
        {
            new User { Id=1, FirstName="Jonah", LastName="Hill", Email="test1@gmail.com", Password="Hola123", IsActive= true, UserRole= 1 },
            new User { Id=2, FirstName="Set", LastName="Rogen", Email="test2@gmail.com", Password="Pass1234", IsActive= true, UserRole= 2 },
            new User { Id=3, FirstName="Kevin", LastName="Hart", Email="test3@gmail.com", Password="Chau1234", IsActive= true, UserRole= 3 },
            new User { Id=4, FirstName="Leonardo", LastName="DiCaprio", Email="test4@gmail.com", Password="Hola123", IsActive= true, UserRole= 1 },
            new User { Id=5, FirstName="Adam", LastName="Sandler", Email="test5@gmail.com", Password="Hola123", IsActive= true, UserRole= 2 }
        };

        public static User MockedUserObj() => new User
        {
            Id = 1,
            FirstName="Esteban",
            LastName="Martinez",
            Email="estebanKpo@gmail.com",
            Password="Hola123",
            IsActive=true,
            UserRole=3
        };
    }
}