using Microsoft.EntityFrameworkCore;
using TwilioClient.Application.Interfaces;
using TwilioClient.Application.Models;
using TwilioClient.Data;

namespace TwilioClient.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _dbContext;

        public AuthService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ValidationResponseModel>
        AuthorizeApp(string appName, string appToken)
        {
            var response =
                new ValidationResponseModel()
                { IsSuccessful = false, Message = string.Empty };

            var callingApp =
                await _dbContext
                    .RegisteredApps
                    .AsNoTracking()
                    .Where(a => a.AppName == appName)
                    .FirstOrDefaultAsync();

            if (callingApp == null)
            {
                response.Message = $"Application {appName} is not registered";
                return response;
            }
            if (callingApp.AppToken != appToken)
            {
                response.Message = $"Invalid app token for {appName}";
                return response;
            }

            response.IsSuccessful = true;
            return response;
        }
    }
}
