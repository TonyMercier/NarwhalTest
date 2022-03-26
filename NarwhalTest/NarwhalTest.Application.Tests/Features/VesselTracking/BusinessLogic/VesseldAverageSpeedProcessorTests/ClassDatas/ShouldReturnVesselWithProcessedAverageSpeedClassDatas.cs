using NarwhalTest.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NarwhalTest.Application.Tests.Features.VesselTracking.BusinessLogic.VesseldAverageSpeedProcessorTests.ClassDatas
{
    public class ShouldReturnVesselWithProcessedAverageSpeedClassDatas : IEnumerable<object[]>
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
                ){ DistanceTraveledInKM= 0.1631},
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
                    DistanceTraveledInKM = 0.1631,
                    AverageSpeedInKmH = 0.4893
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
                ){ DistanceTraveledInKM= 0.4888},
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
                    DistanceTraveledInKM = 0.4888,
                    AverageSpeedInKmH = 1.4664
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
                ){ DistanceTraveledInKM= 1.062},
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
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}