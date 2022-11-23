using TwilioClient.Application.Models;

namespace TwilioClient.Application.Interfaces
{
    public interface IOutboundEmailService
    {
        public Task SaveOutboundEmail(EmailModel emailModel);
    }
}