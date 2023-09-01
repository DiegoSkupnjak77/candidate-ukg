using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineeProgram.Domain.Models;

namespace TraineeProgram.Tests.Mocks
{
    public static class OfferLetterMock
    {
        public static IEnumerable<OfferLetter> MockedOfferLetterList() => new List<OfferLetter> {
            new OfferLetter { IdOfferLetter= 1 , Contract = "test", Salary = 1001, Status = "pending", IdCandidate = 1, IdJobOpening= 1, IdUser =1},
            new OfferLetter { IdOfferLetter= 2 , Contract = "test", Salary = 1002, Status = "pending", IdCandidate = 2, IdJobOpening= 2, IdUser =2},
            new OfferLetter { IdOfferLetter= 3 , Contract = "test", Salary = 1003, Status = "pending", IdCandidate = 3, IdJobOpening= 3, IdUser =3}
        };

        public static OfferLetter MockedOfferLetterObj() => new OfferLetter
        {
            IdOfferLetter = 1,
            Contract = "test",
            Salary = 1000,
            Status = "pending",
            IdCandidate = 1,
            IdJobOpening = 1,
            IdUser = 1
        };
    }
}