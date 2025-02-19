using System;
using System.Runtime.Serialization;

namespace AverageExchangeRate.Exceptions
{
    public class AverageExchangeRateAPIException : AverageExchangeRateBaseException
    {
        public AverageExchangeRateAPIException()
        {
        }

        public AverageExchangeRateAPIException(string message) : base(message)
        {
        }

        public AverageExchangeRateAPIException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AverageExchangeRateAPIException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
