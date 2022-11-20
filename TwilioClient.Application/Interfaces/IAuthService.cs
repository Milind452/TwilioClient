using TwilioClient.Application.Models;

namespace TwilioClient.Application.Interfaces
{
    public interface IAuthService
    {
        public Task<ValidationResponseModel> AuthorizeApp(string appName, string appToken);
    }
}