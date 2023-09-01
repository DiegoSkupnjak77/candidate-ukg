using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeProgram.Domain.Exceptions
{
    public class InterviewException
    {
        [Serializable]
        public class RelationForeignKeyException : Exception
        {
            public RelationForeignKeyException() { }
            public RelationForeignKeyException(string message)
                : base(message) { }
            public RelationForeignKeyException(string message, Exception inner)
                : base(message, inner) { }
        }
    }
}