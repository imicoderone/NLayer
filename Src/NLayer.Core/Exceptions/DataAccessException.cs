using NLayer.Core.Exceptions;
using System;
using System.Runtime.Serialization;

namespace NLayer.Core.Exceptions
{
    public class DataAccessException : BaseException, ISerializable
    {
        public DataAccessException()
            : base()
        {
        }

        public DataAccessException(string message)
            : base(message)
        {
        }

        public DataAccessException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected DataAccessException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
