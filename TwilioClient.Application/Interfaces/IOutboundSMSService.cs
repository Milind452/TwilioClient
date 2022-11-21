using TwilioClient.Application.Models;

namespace TwilioClient.Application.Interfaces
{
    public interface IOutboundSMSService
    {
        public Task SaveOutboundSMS(SMSModel smsModel);
    }
}