using DeepEqual.Syntax;
using NarwhalTest.Application.Features.VesselTracking.BusinessLogic.IntersectionProcessor;
using NarwhalTest.Application.Tests.Features.VesselTracking.BusinessLogic.IntersectionProcessorTests.ClassDatas;
using NarwhalTest.Domain.Entities;
using NarwhalTest.Domain.Entities.Intersections;
using NarwhalTest.Helpers.GeoCalculator;
using System.Collections.Generic;
using Xunit;

namespace NarwhalTest.Application.Tests.Features.VesselTracking.BusinessLogic.IntersectionProcessorTests
{
    public class GetIntersectionsTests
    {
        [Theory]
        [ClassData(typeof(ShouldReturnIntersectionsClassData))]
        public void ShouldReturnIntersections(List<Vessel> input, List<Intersection> expected)
        {
            var processor = new VesselIntersectionProcessor(new GeoCalculator());
            var actual = processor.GetIntersections(input);
            Assert.Equal(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                var ac = actual[i];
                var ex = expected[i];
                ac.IntersectionPoint.ShouldDeepEqual(ex.IntersectionPoint);
                Assert.Equal(ex.Vessel1.Id, ac.Vessel1.Id);
                Assert.Equal(ex.Vessel2.Id, ac.Vessel2.Id);

                Assert.Equal(ex.Vessel1.IntersectionArrivalTime.Date, ac.Vessel1.IntersectionArrivalTime.Date);
                Assert.Equal(ex.Vessel1.IntersectionArrivalTime.Hour, ex.Vessel1.IntersectionArrivalTime.Hour);
                Assert.Equal(ex.Vessel1.IntersectionArrivalTime.Minute, ex.Vessel1.IntersectionArrivalTime.Minute);
                Assert.Equal(ex.Vessel1.IntersectionArrivalTime.Second, ex.Vessel1.IntersectionArrivalTime.Second);

                Assert.Equal(ex.Vessel2.IntersectionArrivalTime.Date, ac.Vessel2.IntersectionArrivalTime.Date);
                Assert.Equal(ex.Vessel2.IntersectionArrivalTime.Hour, ex.Vessel2.IntersectionArrivalTime.Hour);
                Assert.Equal(ex.Vessel2.IntersectionArrivalTime.Minute, ex.Vessel2.IntersectionArrivalTime.Minute);
                Assert.Equal(ex.Vessel2.IntersectionArrivalTime.Second, ex.Vessel2.IntersectionArrivalTime.Second);
            }
        }
        [Theory]
        [ClassData(typeof(ShouldReturnEmptyListClassData))]
        public void ShouldReturnEmptyList(List<Vessel> input)
        {
            var processor = new VesselIntersectionProcessor(new GeoCalculator());
            var actual = processor.GetIntersections(input);
            Assert.Empty(actual);
        }
    }
}