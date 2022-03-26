using NarwhalTest.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NarwhalTest.Application.Tests.Features.VesselTracking.BusinessLogic.VesseldAverageSpeedProcessorTests.ClassDatas
{
    public class ShouldReturnInputClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {//no distance
                new Vessel(123,
                    new List<TrackingPoint>()
                    {
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:00:00"),
                            Latitude = 41.270591735839844,
                            Longitude = -69.0907211303711,
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:20:00"),
                            Latitude = 41.27149200439453,
                            Longitude = -69.08917999267578,
                        }
                    }
                )
            };
            yield return new object[]
            {//empty trackingPoints
                new Vessel(123,
                    new List<TrackingPoint>()
                ){ DistanceTraveledInKM= 0.4888}
            };
            yield return new object[]
            {//null trackingpoints
                new Vessel(123,null){ DistanceTraveledInKM= 1.062},
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}