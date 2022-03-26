using NarwhalTest.Domain.Entities;

namespace NarwhalTest.Application.Features.VesselTracking.BusinessLogic
{
    public interface IVesselDistanceProcessor
    {
        Vessel GetVesselWithProcessedDistance(Vessel vessel);
    }
}