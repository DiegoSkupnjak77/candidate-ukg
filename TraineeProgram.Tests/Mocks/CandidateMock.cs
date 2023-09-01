using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineeProgram.Domain.Models;

namespace TraineeProgram.Tests.Mocks
{
    public static class CandidateMock
    {
        public static IEnumerable<Candidate> MockedCandidateList() => new List<Candidate>
        {
            new Candidate { Id=1, FirstName="Milagros", MiddleName=null, LastName="Perrier", MobilePhone="091111111", Email="miliperrier@gmail.com", Photo=null, CoverLetter=null, UploadResume=null, IsActive=true },
            new Candidate { Id=2, FirstName="Manuela", MiddleName=null, LastName="Tanco", MobilePhone="092222222", Email="manutanco@gmail.com", Photo=null, CoverLetter=null, UploadResume=null, IsActive=false },
            new Candidate { Id=3, FirstName="Esteban", MiddleName="Jose", LastName="Martinez", MobilePhone="093333333", Email="esteban@gmail.com", Photo=null, CoverLetter=null, UploadResume=null, IsActive=true }
        };

        public static Candidate MockedCandidateObj() => new Candidate
        {
            Id = 1,
            FirstName = "Test",
            MiddleName = null,
            LastName = "Candidate",
            MobilePhone = "091111111",
            Email = "test@gmail.com",
            Photo = null,
            CoverLetter = null,
            UploadResume = null,
            IsActive = true
        };
    }
}
