using System;
using System.Runtime.Serialization;

namespace ClassLibraryStudy.Exception
{
    [Serializable]
    class InvalidDisciplineException : System.Exception
    {
        public InvalidDisciplineException()
        {
        }
        public InvalidDisciplineException(string message) : base(message)
        {
        }

        public InvalidDisciplineException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidDisciplineException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
