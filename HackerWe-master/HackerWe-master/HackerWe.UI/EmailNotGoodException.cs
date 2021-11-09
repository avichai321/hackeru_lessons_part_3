using System;
using System.Runtime.Serialization;

namespace HackerWe.UI
{
    [Serializable]
    internal class EmailNotGoodException : Exception
    {
        public EmailNotGoodException()
        {
        }

        public EmailNotGoodException(string? message) : base(message)
        {
        }

        public EmailNotGoodException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EmailNotGoodException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}