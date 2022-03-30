using NarwhalTest.Domain.Entities;
using NarwhalTest.Helpers.GeoCalculator;
using NarwhalTest.Helpers.GeoCalculator.Entities;

namespace NarwhalTest.Application.Features.VesselTracking.BusinessLogic
{

    public class VesselDistanceProcessor : IVesselDistanceProcessor
    {
        private readonly IGeoCalculator _geoCalculator;

        public VesselDistanceProcessor(IGeoCalculator geoCalculator)
        {
            _geoCalculator = geoCalculator;
        }

        public Vessel GetVesselWithProcessedDistance(Vessel vessel)
        {
            if (vessel.Trackings is not null && vessel.Trackings.Any())
            {
                TrackingPoint lastPoint = vessel.Trackings.First();
                double distance = 0;
                foreach (var currentPoint in vessel.Trackings.Skip(1))
                {
                    distance += _geoCalculator.GetDistance(
                        lastPoint.Latitude,
                        lastPoint.Longitude,
                        currentPoint.Latitude,
                        currentPoint.Longitude,
                        4,
                        DistanceUOM.Kilometers
                    );
                    lastPoint = currentPoint;
                }
                vessel.DistanceTraveledInKM = distance;
            }
            return vessel;
        }
    }
}