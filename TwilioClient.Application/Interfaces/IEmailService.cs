using TwilioClient.Application.Models;

namespace TwilioClient.Application.Interfaces
{
    public interface IEmailService
    {
        public Task SaveEmail(EmailModel emailModel);
    }
}