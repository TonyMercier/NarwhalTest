using NarwhalTest.Domain.Entities;

namespace NarwhalTest.Application.Features.VesselTracking.BusinessLogic
{
    public class VesselAverageSpeedProcessor : IVesselAverageSpeedProcessor
    {
        public Vessel GetVesselWithProcessedAverageSpeed(Vessel vessel)
        {
            if (vessel.Trackings is not null && vessel.Trackings.Any() && vessel.DistanceTraveledInKM.HasValue)
            {
                var firstDate = vessel.Trackings.Min(x => x.Date);
                var lastDate = vessel.Trackings.Max(x => x.Date);
                var time = lastDate - firstDate;
                vessel.AverageSpeedInKmH = vessel.DistanceTraveledInKM / time.TotalHours;
            }

            return vessel;
        }
    }
}