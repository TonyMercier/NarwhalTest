using Microsoft.Extensions.DependencyInjection;
using NarwhalService.Client.Configurations;
using Refit;

namespace NarwhalService.Client
{
    public static class NarwhalServiceClientServiceRegistration
    {
        public static IServiceCollection AddNarwhalClientServices(this IServiceCollection services, NarwhalServiceClientConfiguration config)
        {
            services.AddRefitClient<ITrackingController>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(config.BaseUrl));
            return services;
        }
    }
}