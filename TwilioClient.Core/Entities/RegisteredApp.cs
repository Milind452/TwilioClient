namespace TwilioClient.Core.Entities
{
    public class RegisteredApp
    {
        public long Id { get; set; }

        public string AppName { get; set; }

        public string AppToken { get; set; }

        public string TwilioSID { get; set; }

        public string TwilioToken { get; set; }
    }
}
