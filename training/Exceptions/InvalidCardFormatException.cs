using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace training.Exceptions
{
    public class InvalidCardFormatException : ApplicationException
    {
        public InvalidCardFormatException()
        {
        }

        public InvalidCardFormatException(string message) : base(message)
        {
        }

        public InvalidCardFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidCardFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
