using NarwhalService.Client.Dtos;
using NarwhalTest.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace NarwhalTest.Persistence.Tests.MappingTests
{
    internal class VesselMappingProfileTestsClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<TrackingPointDto>()
                {
                    new TrackingPointDto()
                    {
                        Vessel = 1857943,
                        Date = DateTime.Parse("2018-04-23T10:24:11.264Z"),
                        Latitude = 41.27149200439453,
                        Longitude = -69.08917999267578
                    },
                    new TrackingPointDto()
                    {
                        Vessel = 1857943,
                        Date = DateTime.Parse("2018-04-23T10:04:31.616Z"),
                        Latitude = 41.270591735839844,
                        Longitude = -69.0907211303711
                    },
                    new TrackingPointDto()
                    {
                        Vessel = 1857943,
                        Date = DateTime.Parse("2018-04-23T10:43:50.912Z"),
                        Latitude = 41.27067184448242,
                        Longitude = -69.0911865234375
                    },
                    new TrackingPointDto()
                    {
                        Vessel = 3476536,
                        Date = DateTime.Parse("2018-04-23T00:34:21.824Z"),
                        Latitude = 41.49058151245117,
                        Longitude = -69.3577880859375
                    },
                    new TrackingPointDto()
                    {
                        Vessel = 3476536,
                        Date = DateTime.Parse("2018-04-23T02:51:59.36Z"),
                        Latitude = 41.490074157714844,
                        Longitude = -69.36361694335938
                    },
                    new TrackingPointDto()
                    {
                        Vessel = 480772,
                        Date = DateTime.Parse("2018-04-23T08:13:06.944Z"),
                        Latitude = 42.022727966308594,
                        Longitude = -68.24121856689453
                    }
                },
                new List<Vessel>()
                {
                    new Vessel(
                        1857943,
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
                    new Vessel(
                        3476536,
                        new List<TrackingPoint>()
                        {
                             new TrackingPoint()
                            {
                                Date = DateTime.Parse("2018-04-23T00:34:21.824Z"),
                                Latitude = 41.49058151245117,
                                Longitude = -69.3577880859375
                            },
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2018-04-23T02:51:59.36Z"),
                                Latitude = 41.490074157714844,
                                Longitude = -69.36361694335938
                            }
                        }
                    ),
                    new Vessel(
                        480772,
                        new List<TrackingPoint>()
                        {
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2018-04-23T08:13:06.944Z"),
                                Latitude = 42.022727966308594,
                                Longitude = -68.24121856689453
                            }
                        }
                    )
                }
            };

            yield return new object[]
            {
                new List<TrackingPointDto>()
                {
                    new TrackingPointDto()
                    {
                        Vessel = 1857943,
                        Date = DateTime.Parse("2018-04-23T10:24:11.264Z"),
                        Latitude = 41.27149200439453,
                        Longitude = -69.08917999267578
                    },
                   
                    new TrackingPointDto()
                    {
                        Vessel = 3476536,
                        Date = DateTime.Parse("2018-04-23T00:34:21.824Z"),
                        Latitude = 41.49058151245117,
                        Longitude = -69.3577880859375
                    },
                    new TrackingPointDto()
                    {
                        Vessel = 480772,
                        Date = DateTime.Parse("2018-04-23T08:13:06.944Z"),
                        Latitude = 42.022727966308594,
                        Longitude = -68.24121856689453
                    },
                    new TrackingPointDto()
                    {
                        Vessel = 3476536,
                        Date = DateTime.Parse("2018-04-23T02:51:59.36Z"),
                        Latitude = 41.490074157714844,
                        Longitude = -69.36361694335938
                    },
                    new TrackingPointDto()
                    {
                        Vessel = 1857943,
                        Date = DateTime.Parse("2018-04-23T10:04:31.616Z"),
                        Latitude = 41.270591735839844,
                        Longitude = -69.0907211303711
                    },
                    new TrackingPointDto()
                    {
                        Vessel = 1857943,
                        Date = DateTime.Parse("2018-04-23T10:43:50.912Z"),
                        Latitude = 41.27067184448242,
                        Longitude = -69.0911865234375
                    }
                },
                new List<Vessel>()
                {
                    new Vessel(
                        1857943,
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
                    new Vessel(
                        3476536,
                        new List<TrackingPoint>()
                        {
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2018-04-23T00:34:21.824Z"),
                                Latitude = 41.49058151245117,
                                Longitude = -69.3577880859375
                            },
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2018-04-23T02:51:59.36Z"),
                                Latitude = 41.490074157714844,
                                Longitude = -69.36361694335938
                            }
                        }
                    ),
                    new Vessel(
                        480772,
                        new List<TrackingPoint>()
                        {
                            new TrackingPoint()
                            {
                                Date = DateTime.Parse("2018-04-23T08:13:06.944Z"),
                                Latitude = 42.022727966308594,
                                Longitude = -68.24121856689453
                            }
                        }
                    )
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
