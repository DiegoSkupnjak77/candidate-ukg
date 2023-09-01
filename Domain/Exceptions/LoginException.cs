using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeProgram.Domain.Exceptions
{
    [Serializable]
    public class WrongCredentialsException : Exception
    {
        public WrongCredentialsException() { }

        public WrongCredentialsException(string message)
            : base(message) { }

        public WrongCredentialsException(string message, Exception inner)
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
