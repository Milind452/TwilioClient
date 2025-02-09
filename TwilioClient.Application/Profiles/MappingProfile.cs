using AutoMapper;
using TwilioClient.Application.Models;
using TwilioClient.Core.Entities;

namespace TwilioClient.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterAppModel, RegisteredApp>();

            CreateMap<SMSModel, OutboundSMS>();
            CreateMap<RegisteredApp, OutboundSMS>()
                .ForMember(p => p.Id, opt => opt.Ignore());
            
            CreateMap<EmailModel, OutboundEmail>();
            CreateMap<RegisteredApp, OutboundEmail>()
                .ForMember(p => p.Id, opt => opt.Ignore());
        }
    }
}
