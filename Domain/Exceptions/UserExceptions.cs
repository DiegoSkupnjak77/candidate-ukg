namespace TraineeProgram.Domain.Exceptions
{
    public class UserExceptions
    {
        [Serializable]
        public class DuplicateUserException : Exception
        {
            public DuplicateUserException() { }

            public DuplicateUserException(string message)
                : base(message) { }

            public DuplicateUserException(string message, Exception inner)
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

        [Serializable]
        public class RolUserException : Exception
        {
            public RolUserException() { }

            public RolUserException(string message)
                : base(message) { }

            public RolUserException(string message, Exception inner)
                : base(message, inner) { }
        }
    }
}