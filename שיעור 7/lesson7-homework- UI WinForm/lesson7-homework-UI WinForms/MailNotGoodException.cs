using System;
using System.Runtime.Serialization;

namespace lesson7_homework_UI_WinForms
{
    [Serializable]
    internal class MailNotGoodException : Exception
    {
        public MailNotGoodException()
        {
        }

        public MailNotGoodException(string? message) : base(message)
        {
        }

        public MailNotGoodException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
        protected MailNotGoodException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}