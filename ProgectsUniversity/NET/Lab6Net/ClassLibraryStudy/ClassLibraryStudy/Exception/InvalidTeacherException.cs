using System;
using System.Runtime.Serialization;

namespace ClassLibraryStudy.Exception
{
    [Serializable]
    class InvalidTeacherException : System.Exception
    {
        public InvalidTeacherException()
        {
        }
        public InvalidTeacherException(string message) : base(message)
        {
        }

        public InvalidTeacherException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidTeacherException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }

}
