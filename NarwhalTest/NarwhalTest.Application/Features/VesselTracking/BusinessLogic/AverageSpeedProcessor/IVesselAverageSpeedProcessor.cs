using NarwhalTest.Domain.Entities;

namespace NarwhalTest.Application.Features.VesselTracking.BusinessLogic
{
    public interface IVesselAverageSpeedProcessor
    {
        Vessel GetVesselWithProcessedAverageSpeed(Vessel vessel);
    }
}