using System;
using System.Runtime.Serialization;

namespace AverageExchangeRate.Exceptions
{
    public class AverageExchangeRateInvalidArgumentException : AverageExchangeRateBaseException
    {
        public AverageExchangeRateInvalidArgumentException()
        {
        }

        public AverageExchangeRateInvalidArgumentException(string message) : base(message)
        {
        }

        public AverageExchangeRateInvalidArgumentException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AverageExchangeRateInvalidArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
