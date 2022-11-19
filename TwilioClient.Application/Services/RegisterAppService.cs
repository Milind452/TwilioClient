using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TwilioClient.Application.Interfaces;
using TwilioClient.Application.Models;
using TwilioClient.Core.Entities;
using TwilioClient.Data;

namespace TwilioClient.Application.Services
{
    public class RegisterAppService : IRegisterAppService
    {
        private readonly AppDbContext _dbContext;

        private readonly IMapper _mapper;

        public RegisterAppService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task SaveApp(RegisterAppModel app)
        {
            var registeredApp =
                await _dbContext
                    .RegisteredApps
                    .AsNoTracking()
                    .Where(a => a.AppName == app.AppName)
                    .SingleOrDefaultAsync();

            if (registeredApp != null)
            {
                // #TODO: Add custom exception
                throw new Exception();
            }

            var incomingApp = _mapper.Map<RegisteredApp>(app);
            _dbContext.Add (incomingApp);
            await _dbContext.SaveChangesAsync();
        }
    }
}
