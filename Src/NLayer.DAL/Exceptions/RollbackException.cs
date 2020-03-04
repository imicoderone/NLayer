using NLayer.Core.Exceptions;
using System;
using System.Runtime.Serialization;

namespace NLayer.DAL.Exceptions
{
    public class RollbackException : DataAccessException, ISerializable
    {
        public RollbackException()
            : base()
        {
        }

        public RollbackException(string message)
            : base(message)
        {
        }

        public RollbackException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected RollbackException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
