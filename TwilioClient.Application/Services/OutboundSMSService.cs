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
    public class OutboundSMSService : IOutboundSMSService
    {
        private readonly AppDbContext _dbContext;

        private readonly IMapper _mapper;

        public OutboundSMSService(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task SaveOutboundSMS(SMSModel smsModel)
        {
            if (smsModel == null)
            {
                throw new ArgumentNullException();
            }

            var callingApp =
                await _dbContext
                    .RegisteredApps
                    .AsNoTracking()
                    .Where(a => a.AppName == smsModel.AppName)
                    .FirstOrDefaultAsync();

            if (callingApp == null)
            {
                throw new NotFoundException();
            }

            var outboundSMS = _mapper.Map<OutboundSMS>(smsModel);
            _mapper.Map<RegisteredApp, OutboundSMS> (callingApp, outboundSMS);

            outboundSMS.Status = MessageStatus.Pending;

            _dbContext.Add(outboundSMS);
            await _dbContext.SaveChangesAsync();
        }
    }
}
