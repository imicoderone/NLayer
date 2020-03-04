using NLayer.Core.Exceptions;
using System;
using System.Runtime.Serialization;

namespace NLayer.DAL.Exceptions
{
    public class CommitException : DataAccessException, ISerializable
    {
        public CommitException()
            : base()
        {
        }

        public CommitException(string message)
            : base(message)
        {
        }

        public CommitException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected CommitException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
