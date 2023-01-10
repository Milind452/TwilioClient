using TwilioClient.Application.Models;
using TwilioClient.Core.Entities;

namespace TwilioClient.Application.Interfaces
{
    public interface ISMSService
    {
        public Task SaveSMS(SMSModel smsModel);
        public Task SendSMS(OutboundSMS sms);
    }
}