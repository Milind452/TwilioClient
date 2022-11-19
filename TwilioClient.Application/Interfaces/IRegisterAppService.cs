using TwilioClient.Application.Models;

namespace TwilioClient.Application.Interfaces
{
    public interface IRegisterAppService
    {
        public Task SaveApp(RegisterAppModel app);
    }
}