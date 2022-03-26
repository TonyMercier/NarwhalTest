using NarwhalTest.Domain.Entities;

namespace NarwhalTest.Application.Features.VesselTracking.Queries.GetVesselTrackingInfos
{
    public class GetVesselTrackingInfosResponse
    {
        public GetVesselTrackingInfosResponse(List<Vessel> vessels)
        {
            Vessels = vessels;
        }
        public List<Vessel> Vessels { get; set; }
    }
}