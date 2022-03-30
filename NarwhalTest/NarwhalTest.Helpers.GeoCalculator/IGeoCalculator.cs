using NarwhalTest.Helpers.GeoCalculator.Entities;

namespace NarwhalTest.Helpers.GeoCalculator
{
    public interface IGeoCalculator
    {
        double GetDistance(double originLatitude, double originLongitude, double destinationLatitude, double destinationLongitude, int decimalPlaces = 1, DistanceUOM distanceUnit = DistanceUOM.Kilometers);
        DateTime GetArrivalTime(double originLatitude, double originLongitude, double destLatitude, double destLongitude, DateTime originTime, double speedinDistanceUOMperHour, DistanceUOM distanceUOM = DistanceUOM.Kilometers);
    }
}