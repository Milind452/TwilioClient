using TwilioClient.Application.Interfaces;
using TwilioClient.Application.Models;

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
    }
}
