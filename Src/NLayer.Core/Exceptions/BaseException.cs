using System;
using System.Runtime.Serialization;

namespace NLayer.Core.Exceptions
{
    public class BaseException : Exception, ISerializable
    {
        public BaseException()
           : base()
        {
        }

        public BaseException(string message)
           : base(message)
        {
        }

        public BaseException(string message, Exception inner)
           : base(message, inner)
        {
        }

        protected BaseException(SerializationInfo info, StreamingContext context)
           : base(info, context)
        {

        }
    }
}
