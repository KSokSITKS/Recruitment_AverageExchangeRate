using System;
using System.Runtime.Serialization;

namespace AverageExchangeRate.Exceptions
{
    public class AverageExchangeRateBaseException : Exception
    {
        public AverageExchangeRateBaseException()
        {
        }

        public AverageExchangeRateBaseException(string message) : base(message)
        {
        }

        public AverageExchangeRateBaseException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AverageExchangeRateBaseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
