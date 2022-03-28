using NarwhalTest.Domain.Entities;
using NarwhalTest.Domain.Entities.Intersections;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NarwhalTest.Application.Tests.Features.VesselTracking.BusinessLogic.IntersectionProcessorTests.ClassDatas
{
    internal class ShouldReturnEmptyListClassData : IEnumerable<object[]>
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
                            Date = DateTime.Parse("2022-03-22 10:00:00"),
                            Latitude = 0,
                            Longitude = 0
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-22 10:30:00"),
                            Latitude = 1.25,
                            Longitude = 1.25
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-22 11:00:00"),
                            Latitude = 1.5,
                            Longitude = 1.5
                        }
                    }
                    )
                    {
                        DistanceTraveledInKM = 235.9,
                        AverageSpeedInKmH = 235.9
                    },
                    new Vessel(222,
                    new List<TrackingPoint>()
                    {
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:00:00"),
                            Latitude = 1.1,
                            Longitude = 0.9
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 11:00:00"),
                            Latitude = 0.9,
                            Longitude = 1.1
                        }
                    }
                    )
                    {
                        DistanceTraveledInKM = 31.45,
                        AverageSpeedInKmH = 31.45
                    }
                }
            };
            yield return new object[]
            {
                new List<Vessel>()
                {
                    new Vessel(123,
                    new List<TrackingPoint>()
                    {
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 14:00:00"),
                            Latitude = 0,
                            Longitude = 0
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 14:30:00"),
                            Latitude = 1.25,
                            Longitude = 1.25
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 14:00:00"),
                            Latitude = 1.5,
                            Longitude = 1.5
                        }
                    }
                    )
                    {
                        DistanceTraveledInKM = 235.9,
                        AverageSpeedInKmH = 235.9
                    },
                    new Vessel(222,
                    new List<TrackingPoint>()
                    {
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:00:00"),
                            Latitude = 1.1,
                            Longitude = 0.9
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 11:00:00"),
                            Latitude = 0.9,
                            Longitude = 1.1
                        }
                    }
                    )
                    {
                        DistanceTraveledInKM = 31.45,
                        AverageSpeedInKmH = 31.45
                    }
                }
            };
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
                            Latitude = 0,
                            Longitude = 0
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:30:00"),
                            Latitude = 1.25,
                            Longitude = 1.25
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 11:00:00"),
                            Latitude = 1.5,
                            Longitude = 1.5
                        }
                    }
                    )
                    {
                        DistanceTraveledInKM = 235.9,
                        AverageSpeedInKmH = 235.9
                    },
                    new Vessel(222,
                    new List<TrackingPoint>()
                    {
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:00:00"),
                            Latitude = 2.1,
                            Longitude = 2.9
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 11:00:00"),
                            Latitude = 2.9,
                            Longitude = 2.1
                        }
                    }
                    )
                    {
                        DistanceTraveledInKM = 31.45,
                        AverageSpeedInKmH = 31.45
                    }
                }
            };
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
                            Latitude = 0,
                            Longitude = 0
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:30:00"),
                            Latitude = 1.25,
                            Longitude = 1.25
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 11:00:00"),
                            Latitude = 1.5,
                            Longitude = 1.5
                        }
                    }
                    )
                    {
                        DistanceTraveledInKM = 235.9,
                        AverageSpeedInKmH = 235.9
                    }
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
    }
}