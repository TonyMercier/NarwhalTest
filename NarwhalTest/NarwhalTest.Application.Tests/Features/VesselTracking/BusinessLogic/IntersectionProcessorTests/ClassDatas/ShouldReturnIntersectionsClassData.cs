using NarwhalTest.Domain.Entities;
using NarwhalTest.Domain.Entities.Intersections;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NarwhalTest.Application.Tests.Features.VesselTracking.BusinessLogic.IntersectionProcessorTests.ClassDatas
{
    public class ShouldReturnIntersectionsClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<Vessel>()
                {
                    new Vessel(123,
                    new List<TrackingPoint>()
                    {
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:00:00"),
                            Latitude = 41.270591735839844,
                            Longitude = -69.0907211303711
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:20:00"),
                            Latitude = 41.27149200439453,
                            Longitude = -69.08917999267578
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:45:00"),
                            Latitude = 41.27067184448242,
                            Longitude = -69.0911865234375
                        },
                    }
                    )
                    {
                        DistanceTraveledInKM = 1.062,
                        AverageSpeedInKmH = 1.416
                    },
                    new Vessel(222,
                    new List<TrackingPoint>()
                    {
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:00:00"),
                            Latitude = 41.2707909349529,
                            Longitude = -69.0893964485534
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:20:00"),
                            Latitude = 41.2716097967324,
                            Longitude = -69.0904161632222
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:45:00"),
                            Latitude = 41.2713780433986,
                            Longitude = -69.0914204276688
                        },
                    }
                    )
                    {
                        DistanceTraveledInKM = 1.062,
                        AverageSpeedInKmH = 1.416
                    }
                },
                new List<Intersection>()
                {
                    new Intersection()
                    {
                        IntersectionPoint = new IntersectionPoint()
                        {
                            Latitude =41.2711235797577,
                            Longitude = -69.0898106856982
                        },
                        Vessel1 = new IntersectionVessel(123, DateTime.Parse("")),
                        Vessel2 = new IntersectionVessel(222,DateTime.Parse(""))
                    }
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}