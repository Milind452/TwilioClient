using Microsoft.Extensions.DependencyInjection;
using TwilioClient.Application.Services;

namespace TwilioClient.Common.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection
        RegisterServices(this IServiceCollection services)
        {
            services
                .Scan(scan =>
                    scan
                        .FromAssemblyOf<SMSService>()
                        .AddClasses(classes =>
                            classes
                                .Where(type => type.Name.EndsWith("Service")))
                        .AsImplementedInterfaces());

            return services;
        }
    }
}
