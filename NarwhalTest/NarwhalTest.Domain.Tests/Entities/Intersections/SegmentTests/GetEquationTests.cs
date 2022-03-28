using DeepEqual.Syntax;
using NarwhalTest.Domain.Entities.Intersections;
using NarwhalTest.Domain.Tests.Entities.Intersections.SegmentTests.ClassDatas;
using Xunit;

namespace NarwhalTest.Domain.Tests.Entities.Intersections.SegmentTests
{
    public class GetEquationTests
    {
        [Theory]
        [ClassData(typeof(ShouldReturnEquationClassData))]
        public void ShouldReturnEquation(Segment input, LinearEquation expected)
        {
            var actual = input.GetEquation();
            actual.ShouldDeepEqual(expected);
        }
    }
}