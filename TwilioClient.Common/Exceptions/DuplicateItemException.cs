namespace TwilioClient.Common.Exceptions
{
    [System.Serializable]
    public class DuplicateItemExceptionException : System.Exception
    {
        public DuplicateItemExceptionException()
        {
        }

        public DuplicateItemExceptionException(string message) :
            base(message)
        {
        }

        public DuplicateItemExceptionException(
            string message,
            System.Exception inner
        ) :
            base(message, inner)
        {
        }

        protected DuplicateItemExceptionException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context
        ) :
            base(info, context)
        {
        }
    }
}
