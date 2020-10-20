using System;
using System.Runtime.Serialization;

namespace ClassLibraryHotel.Exception
{

    [Serializable]
    public class InvalidRoomException : System.Exception
    {
        public InvalidRoomException()
        {
        }

        public InvalidRoomException(string message) : base(message)
        {
        }

        public InvalidRoomException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidRoomException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
