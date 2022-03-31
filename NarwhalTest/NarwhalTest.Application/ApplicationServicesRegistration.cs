using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NarwhalTest.Application.Features.VesselTracking.BusinessLogic;
using NarwhalTest.Application.Features.VesselTracking.BusinessLogic.IntersectionProcessor;
using NarwhalTest.Helpers.GeoCalculator;
using System.Reflection;

namespace NarwhalTest.Application
{
    public static class ApplicationServicesRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            return services
                .AddMediatR(Assembly.GetExecutingAssembly())
                .AddAutoMapper(Assembly.GetExecutingAssembly())
                .AddSingleton<IVesselAverageSpeedProcessor, VesselAverageSpeedProcessor>()
                .AddSingleton<IVesselDistanceProcessor, VesselDistanceProcessor>()
                .AddSingleton<IVesselIntersectionProcessor, VesselIntersectionProcessor>()
                .AddGeoCalculatorServices();
        }
    }
}