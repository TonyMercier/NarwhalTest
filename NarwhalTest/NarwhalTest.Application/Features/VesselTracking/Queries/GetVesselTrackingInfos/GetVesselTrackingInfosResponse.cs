using NarwhalTest.Domain.Entities;
using NarwhalTest.Domain.Entities.Intersections;

namespace NarwhalTest.Application.Features.VesselTracking.Queries.GetVesselTrackingInfos
{
    public class GetVesselTrackingInfosResponse
    {
        public GetVesselTrackingInfosResponse(List<Vessel> vessels, List<Intersection> intersections)
        {
            Vessels = vessels;
            Intersections = intersections;
        }
        public List<Vessel> Vessels { get; set; }
        public List<Intersection> Intersections { get; set; }
    }
}