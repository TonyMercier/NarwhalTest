using NarwhalTest.Domain.Entities;
using NarwhalTest.Domain.Entities.Intersections;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NarwhalTest.Domain.Tests.Entities.VesselTests.ClassDatas
{
    internal class ShouldReturnEmptyListClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new Vessel(1,new List<TrackingPoint>()
                {
                    new TrackingPoint()
                    {
                        Date = DateTime.Parse("2022-03-27 10:00:00"),
                        Latitude = 1,
                        Longitude = 1,
                    }
                })
            };
            yield return new object[]
            {
                new Vessel(1,new List<TrackingPoint>())
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}