namespace TwilioClient.Common.Exceptions
{
    [System.Serializable]
    public class NotFoundExceptionException : System.Exception
    {
        public NotFoundExceptionException() { }
        public NotFoundExceptionException(string message) : base(message) { }
        public NotFoundExceptionException(string message, System.Exception inner) : base(message, inner) { }
        protected NotFoundExceptionException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }        
}