using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraineeProgram.Domain.Models;

namespace TraineeProgram.Tests.Mocks
{
    public static class InterviewMock
    {
        public static Interview InterviewObj() => new Hr
        {
            Id = 1,
            InterviewName = "Hr",
            InterviewDate = new DateTime(2022, 01, 01),
            Feedback = "Test feedback",
            IsApproved = true,
            Reason = "-",
            IdCandidate = 1,
            IdJobOpening = 1,
            IdUser = 1,
            IdInterview = 1,
            SalaryExpected = 60000
        };
    }
}
