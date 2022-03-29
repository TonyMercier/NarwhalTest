using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NarwhalTest.Application.Features.VesselTracking.Contracts;
using NarwhalTest.NarwhalServiceClient;
using NarwhalTest.NarwhalServiceClient.Options;
using NarwhalTest.Persistence.Repositories;
using System.Reflection;

namespace NarwhalTest.Persistence
{
    public static class PersisenteceServiceRegistrations
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            return services
                .AddMediatR(Assembly.GetExecutingAssembly())
                .AddAutoMapper(Assembly.GetExecutingAssembly())
                .AddNarwhalServiceClientServices()
                .AddSingleton<IVesselTrackingRepository, VesselTrackingRepository>();
        }
    }
}