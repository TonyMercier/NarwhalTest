using NarwhalTest.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NarwhalTest.Application.Tests.Features.VesselTracking.BusinessLogic.VesselDistanceProcessorTests.ClassDatas
{
    internal class ShouldReturnVesselWithProcessedTraveledDistanceClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
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
                ),
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
                {
                    DistanceTraveledInKM = 0.1631
                }
            };
            yield return new object[]
            {
                new Vessel(123,
                    new List<TrackingPoint>()
                    {
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:00:00"),
                            Latitude = 41.49058151245117,
                            Longitude = -69.3577880859375,
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:20:00"),
                            Latitude = 41.490074157714844,
                            Longitude = -69.36361694335938,
                        }
                    }
                ),
                new Vessel(123,
                    new List<TrackingPoint>()
                    {
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:00:00"),
                            Latitude = 41.49058151245117,
                            Longitude = -69.3577880859375,
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:20:00"),
                            Latitude = 41.490074157714844,
                            Longitude = -69.36361694335938,
                        }
                    }
                )
                {
                    DistanceTraveledInKM = 0.4888
                }
            };
            yield return new object[]
            {
                new Vessel(123,
                    new List<TrackingPoint>()
                    {
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2018-04-23T10:04:31.616Z"),
                            Latitude = 41.270591735839844,
                            Longitude = -69.0907211303711
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2018-04-23T10:24:11.264Z"),
                            Latitude = 41.27149200439453,
                            Longitude = -69.08917999267578
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2018-04-23T10:43:50.912Z"),
                            Latitude = 41.27067184448242,
                            Longitude = -69.0911865234375
                        },
                    }
                ),
                new Vessel(123,
                    new List<TrackingPoint>()
                    {
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2018-04-23T10:04:31.616Z"),
                            Latitude = 41.270591735839844,
                            Longitude = -69.0907211303711
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2018-04-23T10:24:11.264Z"),
                            Latitude = 41.27149200439453,
                            Longitude = -69.08917999267578
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2018-04-23T10:43:50.912Z"),
                            Latitude = 41.27067184448242,
                            Longitude = -69.0911865234375
                        },
                    }
                )
                {
                    DistanceTraveledInKM = 0.354
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}