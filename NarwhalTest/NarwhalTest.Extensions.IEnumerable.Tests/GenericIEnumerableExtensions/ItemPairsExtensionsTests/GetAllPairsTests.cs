using DeepEqual.Syntax;
using NarwhalTest.Extensions.IEnumerable.GenericIEnumerableExtensions;
using NarwhalTest.Extensions.IEnumerable.Tests.GenericIEnumerableExtensions.ItemPairsExtensionsTests.ClassDatas;
using NarwhalTest.Extensions.IEnumerable.Tests.GenericIEnumerableExtensions.ItemPairsExtensionsTests.TestTypes;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace NarwhalTest.Extensions.IEnumerable.Tests.GenericIEnumerableExtensions.ItemPairsExtensionsTests
{
    public class GetAllPairsTests
    {
        [Theory]
        [ClassData(typeof(ShouldReturnPairsClassData))]
        public void ShouldReturnPairs(List<GetAllPairsTestType> source, List<(GetAllPairsTestType, GetAllPairsTestType)> expected)
        {
            var actual = source.GetAllPairs((item1, item2) => item1.Id != item2.Id).ToList();
            Assert.Equal(actual.Count, expected.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                actual[i].Item1.ShouldDeepEqual(expected[i].Item1);
                actual[i].Item2.ShouldDeepEqual(expected[i].Item2);
            }
        }
        [Theory]
        [ClassData(typeof(ShouldReturnEmptyListClassData))]
        public void ShouldReturnEmptyList(List<GetAllPairsTestType> source)
        {
            var actual = source.GetAllPairs((item1, item2) => item1.Id != item2.Id);
            Assert.Empty(actual);
        }
    }
}