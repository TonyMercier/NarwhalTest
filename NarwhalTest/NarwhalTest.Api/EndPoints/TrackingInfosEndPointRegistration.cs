using MediatR;
using NarwhalTest.Application.Features.VesselTracking.Queries.GetVesselTrackingInfos;

namespace NarwhalTest.Api.EndPoints
{
    public static class TrackingInfosEndPointRegistration
    {
        public static WebApplication MapTrackingInfosEndPoints(this WebApplication app)
        {
            app.MapGet("/TrackingInfos", (DateTime? from, DateTime? to, int? limit, IMediator mediator) =>
                mediator.Send(new GetVesselTrackingInfosQuery(from, to, limit)));
            return app;
        }
    }
}
