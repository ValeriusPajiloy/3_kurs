using System;
using System.Runtime.Serialization;

namespace ClassLibraryHotel.Exception
{

    [Serializable]
    public class InvalidSettlementException : System.Exception
    {
        public InvalidSettlementException()
        {
        }

        public InvalidSettlementException(string message) : base(message)
        {
        }

        public InvalidSettlementException(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected InvalidSettlementException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
