using TwilioClient.Application.Models;

namespace TwilioClient.Application.Interfaces
{
    public interface ISMSService
    {
        public Task SaveSMS(SMSModel smsModel);
    }
}