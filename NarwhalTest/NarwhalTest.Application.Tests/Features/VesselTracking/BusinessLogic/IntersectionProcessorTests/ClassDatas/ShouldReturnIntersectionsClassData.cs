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
                 },
                 new List<Intersection>()
                 {
                     new Intersection()
                     {
                         IntersectionPoint = new Coordinate()
                         {
                             Latitude = 1,
                             Longitude = 1
                         },
                         Vessel1 = new IntersectionVessel(123, DateTime.Parse("2022-03-25 10:39:59")),
                         Vessel2 = new IntersectionVessel(222,DateTime.Parse("2022-03-25 10:29:59"))
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
                             Latitude = 1,
                             Longitude = 1
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
                         DistanceTraveledInKM = 78.62,
                         AverageSpeedInKmH = 78.62
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
                 },
                 new List<Intersection>()
                 {
                     new Intersection()
                     {
                         IntersectionPoint = new Coordinate()
                         {
                             Latitude = 1,
                             Longitude = 1
                         },
                         Vessel1 = new IntersectionVessel(123, DateTime.Parse("2022-03-25 10:00:00")),
                         Vessel2 = new IntersectionVessel(222,DateTime.Parse("2022-03-25 10:29:59"))
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
                             Date = DateTime.Parse("2022-03-25 10:39:59"),
                             Latitude = 1,
                             Longitude = 1
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
                 },
                 new List<Intersection>()
                 {
                     new Intersection()
                     {
                         IntersectionPoint = new Coordinate()
                         {
                             Latitude = 1,
                             Longitude = 1
                         },
                         Vessel1 = new IntersectionVessel(123, DateTime.Parse("2022-03-25 10:39:59")),
                         Vessel2 = new IntersectionVessel(222,DateTime.Parse("2022-03-25 10:29:59"))
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
                             Date = DateTime.Parse("2022-03-25 10:39:59"),
                             Latitude = 1,
                             Longitude = 1
                         }
                     }
                     )
                     {
                         DistanceTraveledInKM = 157.2,
                         AverageSpeedInKmH = 241.846
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
                 },
                 new List<Intersection>()
                 {
                     new Intersection()
                     {
                         IntersectionPoint = new Coordinate()
                         {
                             Latitude = 1,
                             Longitude = 1
                         },
                         Vessel1 = new IntersectionVessel(123, DateTime.Parse("2022-03-25 10:39:59")),
                         Vessel2 = new IntersectionVessel(222,DateTime.Parse("2022-03-25 10:29:59"))
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
                             Date = DateTime.Parse("2022-03-25 10:39:59"),
                             Latitude = 1,
                             Longitude = 1
                         }
                     }
                     )
                     {
                         DistanceTraveledInKM = 157.2,
                         AverageSpeedInKmH = 241.846
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
                     },
                     new Vessel(333,
                     new List<TrackingPoint>()
                     {
                         new TrackingPoint()
                         {
                             Date = DateTime.Parse("2022-03-25 10:39:59"),
                             Latitude = 1,
                             Longitude = 1
                         },
                         new TrackingPoint()
                         {
                             Date = DateTime.Parse("2022-03-25 10:00:00"),
                             Latitude = 1,
                             Longitude = 5
                         }
                     }
                     )
                     {
                         DistanceTraveledInKM = 157.2,
                         AverageSpeedInKmH = 241.846
                     }
                 },
                 new List<Intersection>()
                 {
                     new Intersection()
                     {
                         IntersectionPoint = new Coordinate()
                         {
                             Latitude = 1,
                             Longitude = 1
                         },
                         Vessel1 = new IntersectionVessel(123, DateTime.Parse("2022-03-25 10:39:59")),
                         Vessel2 = new IntersectionVessel(222,DateTime.Parse("2022-03-25 10:29:59"))
                     },
                     new Intersection()
                     {
                         IntersectionPoint = new Coordinate()
                         {
                             Latitude = 1,
                             Longitude = 1
                         },
                         Vessel1 = new IntersectionVessel(123, DateTime.Parse("2022-03-25 10:39:59")),
                         Vessel2 = new IntersectionVessel(333,DateTime.Parse("2022-03-25 10:39:59"))
                     },
                     new Intersection()
                     {
                         IntersectionPoint = new Coordinate()
                         {
                             Latitude = 1,
                             Longitude = 1
                         },
                         Vessel1 = new IntersectionVessel(222,DateTime.Parse("2022-03-25 10:29:59")),
                         Vessel2 = new IntersectionVessel(333,DateTime.Parse("2022-03-25 10:39:59"))
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
                            Date = DateTime.Parse("2022-03-25 10:39:59"),
                            Latitude = 1,
                            Longitude = 1
                        }
                    }
                    )
                    {
                        DistanceTraveledInKM = 157.2,
                        AverageSpeedInKmH = 241.846
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
                    },
                    new Vessel(333,
                    new List<TrackingPoint>()
                    {
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:39:59"),
                            Latitude = 1,
                            Longitude = 1
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:00:00"),
                            Latitude = -1,
                            Longitude = 5
                        }
                    }
                    )
                    {
                        DistanceTraveledInKM = 157.2,
                        AverageSpeedInKmH = 241.846
                    }
                },
                new List<Intersection>()
                {
                    new Intersection()
                    {
                        IntersectionPoint = new Coordinate()
                        {
                            Latitude = 1,
                            Longitude = 1
                        },
                        Vessel1 = new IntersectionVessel(123, DateTime.Parse("2022-03-25 10:39:59")),
                        Vessel2 = new IntersectionVessel(222,DateTime.Parse("2022-03-25 10:29:59"))
                    },
                    new Intersection()
                    {
                        IntersectionPoint = new Coordinate()
                        {
                            Latitude = 1,
                            Longitude = 1
                        },
                        Vessel1 = new IntersectionVessel(123, DateTime.Parse("2022-03-25 10:39:59")),
                        Vessel2 = new IntersectionVessel(333,DateTime.Parse("2022-03-25 10:39:59"))
                    },
                    new Intersection()
                    {
                        IntersectionPoint = new Coordinate()
                        {
                            Latitude = 1,
                            Longitude = 1
                        },
                        Vessel1 = new IntersectionVessel(222,DateTime.Parse("2022-03-25 10:29:59")),
                        Vessel2 = new IntersectionVessel(333,DateTime.Parse("2022-03-25 10:39:59"))
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
                            Latitude = 2,
                            Longitude = 4
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:30:00"),
                            Latitude =4,
                            Longitude = 10
                        }
                    }
                    )
                    {
                        DistanceTraveledInKM = 702.4,
                        AverageSpeedInKmH = 1404.8
                    },
                    new Vessel(222,
                    new List<TrackingPoint>()
                    {
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:00:00"),
                            Latitude = 2,
                            Longitude = 0
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:30:00"),
                            Latitude = 2,
                            Longitude = 4
                        }
                    }
                    )
                    {
                        DistanceTraveledInKM = 444.5,
                        AverageSpeedInKmH = 889
                    },
                },
                new List<Intersection>()
                {
                    new Intersection()
                    {
                        IntersectionPoint = new Coordinate()
                        {
                            Latitude = 2,
                            Longitude = 4
                        },
                        Vessel1 = new IntersectionVessel(123, DateTime.Parse("2022-03-25 10:00:00")),
                        Vessel2 = new IntersectionVessel(222,DateTime.Parse("2022-03-25 10:30:00"))
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
                            Latitude = 2,
                            Longitude = 4
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:30:00"),
                            Latitude =4,
                            Longitude = 10
                        }
                    }
                    )
                    {
                        DistanceTraveledInKM = 702.4,
                        AverageSpeedInKmH = 1404.8
                    },
                    new Vessel(222,
                    new List<TrackingPoint>()
                    {
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:00:00"),
                            Latitude = 3,
                            Longitude = 0
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:30:00"),
                            Latitude = 3,
                            Longitude = 10
                        }
                    }
                    )
                    {
                        DistanceTraveledInKM = 1110,
                        AverageSpeedInKmH = 2220
                    },
                },
                new List<Intersection>()
                {
                    new Intersection()
                    {
                        IntersectionPoint = new Coordinate()
                        {
                            Latitude = 3,
                            Longitude = 7
                        },
                        Vessel1 = new IntersectionVessel(123, DateTime.Parse("2022-03-25 10:15:00")),
                        Vessel2 = new IntersectionVessel(222,DateTime.Parse("2022-03-25 10:21:00"))
                    }
                }
            };
            yield return new object[]
             {
                new List<Vessel>()
                {
                    new Vessel(222,
                    new List<TrackingPoint>()
                    {
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:00:00"),
                            Latitude = 3,
                            Longitude = 0
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:30:00"),
                            Latitude = 3,
                            Longitude = 10
                        }
                    }
                    )
                    {
                        DistanceTraveledInKM = 1110,
                        AverageSpeedInKmH = 2220
                    },
                    new Vessel(123,
                    new List<TrackingPoint>()
                    {
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:00:00"),
                            Latitude = 2,
                            Longitude = 4
                        },
                        new TrackingPoint()
                        {
                            Date = DateTime.Parse("2022-03-25 10:30:00"),
                            Latitude =4,
                            Longitude = 10
                        }
                    }
                    )
                    {
                        DistanceTraveledInKM = 702.4,
                        AverageSpeedInKmH = 1404.8
                    }
                },
                new List<Intersection>()
                {
                    new Intersection()
                    {
                        IntersectionPoint = new Coordinate()
                        {
                            Latitude = 3,
                            Longitude = 7
                        },
                        Vessel1 = new IntersectionVessel(222,DateTime.Parse("2022-03-25 10:21:00")),
                        Vessel2 = new IntersectionVessel(123, DateTime.Parse("2022-03-25 10:15:00"))
                    }
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}