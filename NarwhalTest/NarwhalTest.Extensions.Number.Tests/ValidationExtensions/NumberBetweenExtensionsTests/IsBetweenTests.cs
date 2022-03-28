using NarwhalTest.Extensions.Number.ValidationExtensions;
using Xunit;

namespace NarwhalTest.Extensions.Number.Tests.ValidationExtensions.NumberBetweenExtensionsTests
{
    public class IsBetweenTests
    {
        [Theory]
        [InlineData(1,0,2)]
        [InlineData(1, 2, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(1, -100, 200)]
        [InlineData(1, 200, -100)]
        [InlineData(2, 2, 1)]
        public void ShouldReturnTrue(double numberToCheck, double limit1, double limit2)
        {
            var result = numberToCheck.IsBetween(limit1, limit2);
            Assert.True(result);
        }
        [Theory]
        [InlineData(1, 3, 2)]
        [InlineData(1, 2, 3)]
        [InlineData(1, 11, 21)]
        [InlineData(1, 11, 11)]
        [InlineData(-1, 200, 100)]
        [InlineData(-2, 2, 1)]
        public void ShouldReturnFalse(double numberToCheck, double limit1, double limit2)
        {
            var result = numberToCheck.IsBetween(limit1, limit2);
            Assert.False(result);
        }
    }
}