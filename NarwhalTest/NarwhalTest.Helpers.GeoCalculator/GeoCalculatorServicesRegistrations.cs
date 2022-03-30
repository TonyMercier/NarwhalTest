using Microsoft.Extensions.DependencyInjection;

namespace NarwhalTest.Helpers.GeoCalculator
{
    public static class GeoCalculatorServicesRegistrations
    {
        public static IServiceCollection AddGeoCalculatorServices(IServiceCollection services)
        {
            services.AddSingleton<IGeoCalculator,GeoCalculator>();
            return services;
        }
    }
}