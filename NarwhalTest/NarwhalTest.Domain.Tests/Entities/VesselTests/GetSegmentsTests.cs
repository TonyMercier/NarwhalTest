using DeepEqual.Syntax;
using NarwhalTest.Domain.Entities;
using NarwhalTest.Domain.Entities.Intersections;
using NarwhalTest.Domain.Tests.Entities.VesselTests.ClassDatas;
using System.Collections.Generic;
using Xunit;

namespace NarwhalTest.Domain.Tests.Entities.VesselTests
{
    public class GetSegmentsTests
    {
        [Theory]
        [ClassData(typeof(ShouldReturnSegmentsClassData))]
        public void ShouldReturnSegments(Vessel input, List<Segment> expected)
        {
            var actual = input.GetSegments();
            actual.ShouldDeepEqual(expected);
        }
        [Theory]
        [ClassData(typeof(ShouldReturnEmptyListClassData))]
        public void ShouldReturnEmptyList(Vessel input)
        {
            var actual = input.GetSegments();
            Assert.Empty(actual);
        }
    }
}