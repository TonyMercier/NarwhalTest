using NarwhalTest.Domain.Entities;
using NarwhalTest.Domain.Entities.Intersections;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NarwhalTest.Domain.Tests.Entities.VesselTests.ClassDatas
{
    public class ShouldReturnSegmentsClassData : IEnumerable<object[]>
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
                    },
                    new TrackingPoint()
                    {
                        Date = DateTime.Parse("2022-03-27 10:20:00"),
                        Latitude = 2,
                        Longitude = 2,
                    }
                }),
                new List<Segment>()
                {
                    new Segment(
                        new Vessel(1,new List<TrackingPoint>()
                        {
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2022-03-27 10:00:00"),
                                Latitude = 1,
                                Longitude = 1,
                            },
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2022-03-27 10:20:00"),
                                Latitude = 2,
                                Longitude = 2,
                            }
                        }),
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-27 10:00:00"),
                            Latitude = 1,
                            Longitude = 1,
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-27 10:20:00"),
                            Latitude = 2,
                            Longitude = 2,
                        }
                    )
                }
            };
            yield return new object[]
            {
                new Vessel(1,new List<TrackingPoint>()
                {
                    new TrackingPoint()
                    {
                        Date = DateTime.Parse("2022-03-27 10:00:00"),
                        Latitude = 1,
                        Longitude = 1,
                    },
                    new TrackingPoint()
                    {
                        Date = DateTime.Parse("2022-03-27 10:20:00"),
                        Latitude = 2,
                        Longitude = 2,
                    },
                    new TrackingPoint()
                    {
                        Date = DateTime.Parse("2022-03-27 10:40:00"),
                        Latitude = 3,
                        Longitude = 4,
                    },
                    new TrackingPoint()
                    {
                        Date = DateTime.Parse("2022-03-27 10:50:00"),
                        Latitude = 7,
                        Longitude = 8,
                    }
                }),
                new List<Segment>()
                {
                    new Segment(
                        new Vessel(1,new List<TrackingPoint>()
                        {
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2022-03-27 10:00:00"),
                                Latitude = 1,
                                Longitude = 1,
                            },
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2022-03-27 10:20:00"),
                                Latitude = 2,
                                Longitude = 2,
                            },
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2022-03-27 10:40:00"),
                                Latitude = 3,
                                Longitude = 4,
                            },
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2022-03-27 10:50:00"),
                                Latitude = 7,
                                Longitude = 8,
                            }
                        }),
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-27 10:00:00"),
                            Latitude = 1,
                            Longitude = 1,
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-27 10:20:00"),
                            Latitude = 2,
                            Longitude = 2,
                        }
                    ),
                    new Segment(
                        new Vessel(1,new List<TrackingPoint>()
                        {
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2022-03-27 10:00:00"),
                                Latitude = 1,
                                Longitude = 1,
                            },
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2022-03-27 10:20:00"),
                                Latitude = 2,
                                Longitude = 2,
                            },
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2022-03-27 10:40:00"),
                                Latitude = 3,
                                Longitude = 4,
                            },
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2022-03-27 10:50:00"),
                                Latitude = 7,
                                Longitude = 8,
                            }
                        }),
                        new TrackingPoint()
                        {
                             Date = DateTime.Parse("2022-03-27 10:20:00"),
                                Latitude = 2,
                                Longitude = 2,
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-27 10:40:00"),
                            Latitude = 3,
                            Longitude = 4,
                        }
                    ),
                    new Segment(
                        new Vessel(1,new List<TrackingPoint>()
                        {
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2022-03-27 10:00:00"),
                                Latitude = 1,
                                Longitude = 1,
                            },
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2022-03-27 10:20:00"),
                                Latitude = 2,
                                Longitude = 2,
                            },
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2022-03-27 10:40:00"),
                                Latitude = 3,
                                Longitude = 4,
                            },
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2022-03-27 10:50:00"),
                                Latitude = 7,
                                Longitude = 8,
                            }
                        }),
                        new TrackingPoint()
                        {
                             Date = DateTime.Parse("2022-03-27 10:40:00"),
                            Latitude = 3,
                            Longitude = 4,
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-27 10:50:00"),
                            Latitude = 7,
                            Longitude = 8,
                        }
                    ),
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}