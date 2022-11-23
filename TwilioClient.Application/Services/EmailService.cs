using TwilioClient.Application.Interfaces;
using TwilioClient.Application.Models;

namespace TwilioClient.Application.Services
{
    public class EmailService : IEmailService
    {
        private readonly IOutboundEmailService _outboundEmailService;

        public EmailService(IOutboundEmailService outboundEmailService)
        {
            _outboundEmailService = outboundEmailService;
        }

        public async Task SaveEmail(EmailModel emailModel)
        {
            if (emailModel == null)
            {
                throw new ArgumentNullException();
            }

            await _outboundEmailService.SaveOutboundEmail(emailModel);
        }
    }
}
