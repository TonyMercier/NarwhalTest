using Geolocation;
using NarwhalTest.Helpers.GeoCalculator.Entities;

namespace NarwhalTest.Helpers.GeoCalculator
{
    public class GeoCalculator : IGeoCalculator
    {
        public DateTime GetArrivalTime(double originLatitude, double originLongitude, double destLatitude, double destLongitude, DateTime originTime, double speedinDistanceUOMperHour, DistanceUOM distanceUOM = DistanceUOM.Kilometers)
        {
            var distanceToIntersect = GetDistance(
                        originLatitude,
                        originLongitude,
                        destLatitude,
                        destLongitude,
                        12,
                        distanceUOM
                    );

            return originTime.AddHours(distanceToIntersect / speedinDistanceUOMperHour);
        }

        public double GetDistance(double originLatitude, double originLongitude, double destinationLatitude, double destinationLongitude, int decimalPlaces = 1, DistanceUOM distanceUnit = DistanceUOM.Kilometers)
        {
            return Geolocation.GeoCalculator.GetDistance(
                        originLatitude,
                        originLongitude,
                        destinationLatitude,
                        destinationLongitude,
                        decimalPlaces,
                        Enum.Parse<DistanceUnit>(distanceUnit.ToString())
                    );
        }
    }
}