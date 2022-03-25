using MediatR;

namespace NarwhalTest.Application.Features.VesselTracking.Queries.GetVesselTrackingInfos
{
    internal class GetVesselTrackingInfosQuery : IRequest
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int MaxNumber { get; set; }
    }
}