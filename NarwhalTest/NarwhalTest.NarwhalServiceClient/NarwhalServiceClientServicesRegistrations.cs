using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NarwhalTest.NarwhalServiceClient.Options;
using Refit;

namespace NarwhalTest.NarwhalServiceClient
{
    public static class NarwhalServiceClientServicesRegistrations
    {
        public static IServiceCollection AddNarwhalServiceClientServices(this IServiceCollection services)
        {
            services
                .AddSingleton<INarwhalServiceTracking, NarwhalServiceTracking>();
            return services;
        }
    }
}