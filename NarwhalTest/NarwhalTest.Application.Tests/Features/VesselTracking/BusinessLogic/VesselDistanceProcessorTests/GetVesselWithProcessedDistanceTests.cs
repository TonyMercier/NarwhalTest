using DeepEqual.Syntax;
using NarwhalTest.Application.Features.VesselTracking.BusinessLogic;
using NarwhalTest.Application.Tests.Features.VesselTracking.BusinessLogic.VesselDistanceProcessorTests.ClassDatas;
using NarwhalTest.Domain.Entities;
using NarwhalTest.Helpers.GeoCalculator;
using Xunit;

namespace NarwhalTest.Application.Tests.Features.VesselTracking.BusinessLogic.VesselDistanceProcessorTests
{
    public class GetVesselWithProcessedDistanceTests
    {
        [Theory]
        [ClassData(typeof(ShouldReturnVesselWithProcessedTraveledDistanceClassData))]
        public void ShouldReturnVesselWithProcessedTraveledDistance(Vessel input, Vessel expected)
        {
            var processor = new VesselDistanceProcessor(new GeoCalculator());
            var actual = processor.GetVesselWithProcessedDistance(input);
            actual.ShouldDeepEqual(expected);
        }

        [Theory]
        [ClassData(typeof(ShouldReturnInputClassData))]
        public void ShouldReturnInput(Vessel input)
        {
            var processor = new VesselDistanceProcessor(new GeoCalculator());
            var actual = processor.GetVesselWithProcessedDistance(input);
            actual.ShouldDeepEqual(input);
        }
    }
}