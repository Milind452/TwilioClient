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
        }
    }
}
