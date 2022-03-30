using NarwhalTest.Helpers.GeoCalculator.Entities;
using NarwhalTest.Helpers.GeoCalculator.Tests.GeoCalculatorTests.GetArrivalTimeTests.ClassDatas;
using System;
using Xunit;

namespace NarwhalTest.Helpers.GeoCalculator.Tests.GeoCalculatorTests.GetArrivalTimeTests
{
    public class GetArrivalTimeTests
    {
        [Theory]
        [ClassData(typeof(ShouldReturnArrivalTimeClassData))]
        public void ShouldReturnArrivalTime(DateTime expected,double originLatitude, double originLongitude, double destLatitude, double destLongitude, DateTime originTime, double speedinDistanceUOMperHour, DistanceUOM distanceUOM)
        {
            var calculator = new GeoCalculator();
            var actual = calculator.GetArrivalTime(originLatitude, originLongitude, destLatitude, destLongitude, originTime, speedinDistanceUOMperHour, distanceUOM);
            Assert.Equal(expected.Date, actual.Date);
            Assert.Equal(expected.Hour, actual.Hour);
            Assert.Equal(expected.Minute, actual.Minute);
            Assert.Equal(expected.Second, actual.Second);
        }
    }
}