using NarwhalTest.Helpers.GeoCalculator.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NarwhalTest.Helpers.GeoCalculator.Tests.GeoCalculatorTests.GetArrivalTimeTests.ClassDatas
{
    internal class ShouldReturnArrivalTimeClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                DateTime.Parse("2020-03-30 11:57:55"),//expected
                1,1,//originPoint
                2,2,//DestPoint
                DateTime.Parse("2020-03-30 10:00:00"),//originTime
                80,//SpeedInDistanceUOMPerHour
                DistanceUOM.Kilometers//DistanceUOM
            };
            yield return new object[]
            {
                DateTime.Parse("2020-03-30 11:13:16"),//expected
                1,1,//originPoint
                2,2,//DestPoint
                DateTime.Parse("2020-03-30 10:00:00"),//originTime
                80,//SpeedInDistanceUOMPerHour
                DistanceUOM.Miles//DistanceUOM
            };
            yield return new object[]
            {
                DateTime.Parse("2020-03-30 15:53:47"),//expected
                -1,1,//originPoint
                2,-2,//DestPoint
                DateTime.Parse("2020-03-30 10:00:00"),//originTime
                80,//SpeedInDistanceUOMPerHour
                DistanceUOM.Kilometers//DistanceUOM
            };
            yield return new object[]
            {
                DateTime.Parse("2020-03-30 12:21:31"),//expected
                -1,1,//originPoint
                2,-2,//DestPoint
                DateTime.Parse("2020-03-30 10:00:00"),//originTime
                200,//SpeedInDistanceUOMPerHour
                DistanceUOM.Kilometers//DistanceUOM
            };
        }

        IEnumerator IEnumerable.GetEnumerator()=> GetEnumerator();
    }
}