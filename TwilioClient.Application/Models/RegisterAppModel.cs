namespace TwilioClient.Application.Models
{
    public class RegisterAppModel
    {
        public string AppName { get; set; }

        public string AppToken { get; set; }

        public string TwilioSID { get; set; }

        public string TwilioToken { get; set; }

        public string SendGridAPIKey { get; set; }
    }
}
