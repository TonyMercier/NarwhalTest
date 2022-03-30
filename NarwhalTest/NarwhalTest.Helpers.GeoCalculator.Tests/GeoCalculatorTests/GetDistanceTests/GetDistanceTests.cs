using NarwhalTest.Helpers.GeoCalculator.Entities;
using Xunit;

namespace NarwhalTest.Helpers.GeoCalculator.Tests.GeoCalculatorTests.GetDistanceTests
{
    public class GetDistanceTests
    {
        [Theory]
        [InlineData(0,1,1,1,1,5,DistanceUOM.Kilometers)]
        [InlineData(157.22543, 1, 1, 2, 2, 5, DistanceUOM.Kilometers)]
        [InlineData(97.70138, 1, 1, 2, 2, 5, DistanceUOM.Miles)]
        [InlineData(84.89334, 1, 1, 2, 2, 5, DistanceUOM.NauticalMiles)]
        [InlineData(157225.43204, 1, 2, 2, 1, 5, DistanceUOM.Meters)]

        [InlineData(760.57375, -1.8, -1.6, 0, 5, 5, DistanceUOM.Kilometers)]
        [InlineData(472.62776, -1.8, -1.6, 0, 5, 5, DistanceUOM.Miles)]
        [InlineData(410.66924, -1.8, -1.6, 0, 5, 5, DistanceUOM.NauticalMiles)]
        [InlineData(760573.751, -1.8, -1.6, 0, 5, 5, DistanceUOM.Meters)]

        [InlineData(761, -1.8, -1.6, 0, 5, 0, DistanceUOM.Kilometers)]
        [InlineData(760.6, -1.8, -1.6, 0, 5, 1, DistanceUOM.Kilometers)]
        public void ShouldReturnDistance(double expected,double originLatitude, double originLongitude, double destinationLatitude, double destinationLongitude, int decimalPlaces = 1, DistanceUOM distanceUnit = DistanceUOM.Kilometers)
        {
            var calculator = new GeoCalculator();
            var actual = calculator.GetDistance(originLatitude, originLongitude, destinationLatitude, destinationLongitude, decimalPlaces, distanceUnit);
            Assert.Equal(expected, actual);
        }
    }
}