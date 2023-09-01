using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeProgram.Domain.Exceptions
{
    public class CandidateException
    {
        [Serializable]
        public class DuplicateCandidateException : Exception
        {
            public DuplicateCandidateException() { }

            public DuplicateCandidateException(string message)
                : base(message) { }

            public DuplicateCandidateException(string message, Exception inner)
                : base(message, inner) { }
        }

        [Serializable]
        public class FieldRequiredException : Exception
        {
            public FieldRequiredException() { }

            public FieldRequiredException(string message)
                : base(message) { }

            public FieldRequiredException(string message, Exception inner)
                : base(message, inner) { }
        }
    }
}
