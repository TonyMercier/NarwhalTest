using NarwhalTest.Extensions.IEnumerable.Tests.GenericIEnumerableExtensions.ItemPairsExtensionsTests.TestTypes;
using System.Collections;
using System.Collections.Generic;

namespace NarwhalTest.Extensions.IEnumerable.Tests.GenericIEnumerableExtensions.ItemPairsExtensionsTests.ClassDatas
{
    internal class ShouldReturnEmptyListClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<GetAllPairsTestType>()
            };
            yield return new object[]
            {
                new List<GetAllPairsTestType>()
                {
                    new GetAllPairsTestType(1,"awd")
                }
            };
            yield return new object[]
            {
                new List<GetAllPairsTestType>()
                {//in the test, entries with the same ID cant be matched
                    new GetAllPairsTestType(1,"awd"),
                    new GetAllPairsTestType(1,"222"),
                    new GetAllPairsTestType(1,"dd"),
                    new GetAllPairsTestType(1,"awawdd"),
                    new GetAllPairsTestType(1,"awd23444"),
                }
            };
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
    }
}