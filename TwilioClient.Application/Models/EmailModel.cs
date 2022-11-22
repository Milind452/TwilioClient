namespace TwilioClient.Application.Models
{
    public class EmailModel
    {
        public string AppName { get; set; }

        public string AppToken { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public string Body { get; set; }

        public string Subject { get; set; }
    }
}
