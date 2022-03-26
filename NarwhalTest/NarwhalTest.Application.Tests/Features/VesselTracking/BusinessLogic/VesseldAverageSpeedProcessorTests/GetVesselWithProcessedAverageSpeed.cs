using DeepEqual.Syntax;
using NarwhalTest.Application.Features.VesselTracking.BusinessLogic;
using NarwhalTest.Application.Tests.Features.VesselTracking.BusinessLogic.VesseldAverageSpeedProcessorTests.ClassDatas;
using NarwhalTest.Domain.Entities;
using Xunit;

namespace NarwhalTest.Application.Tests.Features.VesselTracking.BusinessLogic.VesseldAverageSpeedProcessorTests
{
    public class GetVesselWithProcessedAverageSpeed
    {
        [Theory]
        [ClassData(typeof(ShouldReturnVesselWithProcessedAverageSpeedClassDatas))]
        public void ShouldReturnVesselWithProcessedAverageSpeed(Vessel input, Vessel expected)
        {
            var processor = new VesselAverageSpeedProcessor();
            var actual = processor.GetVesselWithProcessedAverageSpeed(input);
            actual.ShouldDeepEqual(expected);
        }

        [Theory]
        [ClassData(typeof(ShouldReturnInputClassData))]
        public void ShouldReturnInput(Vessel input)
        {
            var processor = new VesselAverageSpeedProcessor();
            var actual = processor.GetVesselWithProcessedAverageSpeed(input);
            actual.ShouldDeepEqual(input);
        }
    }
}