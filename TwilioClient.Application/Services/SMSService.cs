using Twilio;
using TwilioClient.Application.Interfaces;
using TwilioClient.Application.Models;
using TwilioClient.Core.Entities;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

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

        public async Task<MessageResource> SendSMS(OutboundSMS sms)
        {
            if (sms == null)
            {
                throw new ArgumentNullException();
            }

            Twilio.TwilioClient.Init(sms.TwilioSID, sms.TwilioToken);
            var messageResponse =
                await MessageResource
                    .CreateAsync(to: new PhoneNumber(sms.To),
                    from: new PhoneNumber(sms.From),
                    body: sms.Body);

            var Status = messageResponse.Status;
            return messageResponse;
        }
    }
}
