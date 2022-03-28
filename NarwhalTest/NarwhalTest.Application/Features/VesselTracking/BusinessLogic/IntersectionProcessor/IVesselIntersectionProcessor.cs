using NarwhalTest.Domain.Entities;
using NarwhalTest.Domain.Entities.Intersections;

namespace NarwhalTest.Application.Features.VesselTracking.BusinessLogic.IntersectionProcessor
{
    public interface IVesselIntersectionProcessor
    {
        List<Intersection> GetIntersections(List<Vessel> vessels, float intersectTresholdInHour = 1);
    }
}