using TwilioClient.Application.Interfaces;
using TwilioClient.Application.Models;
using TwilioClient.Core.Entities;

namespace TwilioClient.Application.Services
{
    public class SMSService : ISMSService
    {
        private readonly IOutboundSMSService _outboundSMSService;

        public SMSService(IOutboundSMSService outboundSMSService)
        {
            _outboundSMSService = outboundSMSService;
        }

        public async Task SaveSMS(SMSModel smsModel)
        {
            if (smsModel == null)
            {
                throw new ArgumentNullException();
            }

            await _outboundSMSService.SaveOutboundSMS(smsModel);
        }

        public async Task SendSMS(OutboundSMS sms)
        {
            if (sms == null)
            {
                throw new ArgumentNullException();
            }

            // #TODO: send sms using twilio client
        }
    }
}
