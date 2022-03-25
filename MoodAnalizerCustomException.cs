using System;
using System.Runtime.Serialization;

namespace UC3enteredInvalidMood
{
    [Serializable]
    internal class MoodAnalizerCustomException : Exception
    {
        private object empty_Message;
        private string v;

        public MoodAnalizerCustomException()
        {
        }

        public MoodAnalizerCustomException(string message) : base(message)
        {
        }

        public MoodAnalizerCustomException(object empty_Message, string v)
        {
            this.empty_Message = empty_Message;
            this.v = v;
        }

        public MoodAnalizerCustomException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MoodAnalizerCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public static object ExceptionType { get; internal set; }
    }
}