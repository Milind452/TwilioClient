using TwilioClient.Common.Enums;

namespace TwilioClient.Core.Entities
{
    public class OutboundSMS
    {
        public long Id { get; set; }

        public string AppName { get; set; }

        public string TwilioSID { get; set; }

        public string TwilioToken { get; set; }

        public string Body { get; set; }

        public string To { get; set; }

        public string From { get; set; }

        public DateTime? ReceivedUTC { get; set; }

        public DateTime? SentUTC { get; set; }

        public MessageStatus Status { get; set; }

        public string MessageResponse { get; set; }

        public Guid ExternalId { get; set; }
    }
}
