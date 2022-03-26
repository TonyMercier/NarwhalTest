using Geolocation;
using NarwhalTest.Domain.Entities;

namespace NarwhalTest.Application.Features.VesselTracking.BusinessLogic
{
    public class VesselDistanceProcessor : IVesselDistanceProcessor
    {
        public Vessel GetVesselWithProcessedDistance(Vessel vessel)
        {
            if (vessel.Trackings is not null && vessel.Trackings.Any())
            {
                TrackingPoint lastPoint = vessel.Trackings.First();
                double distance = 0;
                foreach (var currentPoint in vessel.Trackings.Skip(1))
                {
                    distance += GeoCalculator.GetDistance(
                        lastPoint.Latitude,
                        lastPoint.Longitude,
                        currentPoint.Latitude,
                        currentPoint.Longitude,
                        4,
                        DistanceUnit.Kilometers
                    );
                    lastPoint = currentPoint;
                }
                vessel.DistanceTraveledInKM = distance;
            }
            return vessel;
        }
    }
}