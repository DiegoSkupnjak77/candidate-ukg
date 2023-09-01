namespace TraineeProgram.Domain.Exceptions
{
    public class OfferLetterException
    {
        [Serializable]
        public class EntityDoesntExistException : Exception
        {
            public EntityDoesntExistException() { }

            public EntityDoesntExistException(string message)
                : base(message) { }

            public EntityDoesntExistException(string message, Exception inner)
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
