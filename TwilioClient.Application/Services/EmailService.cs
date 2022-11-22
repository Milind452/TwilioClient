using TwilioClient.Application.Interfaces;
using TwilioClient.Application.Models;

namespace TwilioClient.Application.Services
{
    public class EmailService : IEmailService
    {
        public EmailService()
        {
        }

        public Task SaveEmail(EmailModel emailModel)
        {
            if (emailModel == null)
            {
                throw new ArgumentNullException();
            }

            // #TODO: call outbound email service
            throw new NotImplementedException();
        }
    }
}
