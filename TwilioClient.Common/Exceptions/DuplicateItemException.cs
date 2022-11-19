namespace TwilioClient.Common.Exceptions
{
    [System.Serializable]
    public class DuplicateItemException : System.Exception
    {
        public DuplicateItemException()
        {
        }

        public DuplicateItemException(string message) :
            base(message)
        {
        }

        public DuplicateItemException(string message, System.Exception inner) :
            base(message, inner)
        {
        }

        protected DuplicateItemException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context
        ) :
            base(info, context)
        {
        }
    }
}
