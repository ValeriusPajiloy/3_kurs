using System;
using System.Runtime.Serialization;


namespace ClassLibraryStudy.Exception
{
    [Serializable]
    class InvalidWorkloadException : System.Exception
    {
        public InvalidWorkloadException()
        {
        }
        public InvalidWorkloadException(string message) : base(message)
        {
        }

        public InvalidWorkloadException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidWorkloadException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
