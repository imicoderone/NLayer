using System;
using System.Runtime.Serialization;

namespace NLayer.Core.Exceptions
{
    public class BusinessLogicException : BaseException, ISerializable
    {
        public BusinessLogicException()
            : base()
        {
        }

        public BusinessLogicException(string message)
            : base(message)
        {
        }

        public BusinessLogicException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected BusinessLogicException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
