using NarwhalTest.Domain.Entities;
using NarwhalTest.Domain.Entities.Intersections;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NarwhalTest.Domain.Tests.Entities.Intersections.SegmentTests.ClassDatas
{
    internal class ShouldReturnEquationClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new Segment(
                    new Vessel(1,new List<TrackingPoint>()),
                    new TrackingPoint()
                    {
                        Date = DateTime.Now,
                        Latitude = 1,
                        Longitude = 1,
                    },
                    new TrackingPoint()
                    {
                        Date = DateTime.Now,
                        Latitude = 2,
                        Longitude = 2,
                    }
                ),
                new LinearEquation(1,0)
            };
            yield return new object[]
            {
                new Segment(
                    new Vessel(1,new List<TrackingPoint>()),
                    new TrackingPoint()
                    {
                        Date = DateTime.Now,
                        Latitude = 34,
                        Longitude = 55,
                    },
                    new TrackingPoint()
                    {
                        Date = DateTime.Now,
                        Latitude = 78,
                        Longitude = 8,
                    }
                ),
                new LinearEquation(-1.0681818181818181,91.31818181818181)
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}