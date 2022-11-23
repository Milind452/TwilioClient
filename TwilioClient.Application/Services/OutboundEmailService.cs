using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TwilioClient.Application.Interfaces;
using TwilioClient.Application.Models;
using TwilioClient.Common.Enums;
using TwilioClient.Common.Exceptions;
using TwilioClient.Core.Entities;
using TwilioClient.Data;

namespace TwilioClient.Application.Services
{
    public class OutboundEmailService : IOutboundEmailService
    {
        private readonly AppDbContext _dbContext;

        private readonly IMapper _mapper;

        public OutboundEmailService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task SaveOutboundEmail(EmailModel emailModel)
        {
            if (emailModel == null)
            {
                throw new ArgumentNullException();
            }

            var callingApp =
                await _dbContext
                    .RegisteredApps
                    .AsNoTracking()
                    .Where(a => a.AppName == emailModel.AppName)
                    .FirstOrDefaultAsync();

            if (callingApp == null)
            {
                throw new NotFoundException();
            }

            var outboundEmail = _mapper.Map<OutboundEmail>(emailModel);
            _mapper.Map<RegisteredApp, OutboundEmail> (
                callingApp,
                outboundEmail
            );

            outboundEmail.Status = MessageStatus.Pending;

            _dbContext.Add (outboundEmail);
            await _dbContext.SaveChangesAsync();
        }
    }
}
