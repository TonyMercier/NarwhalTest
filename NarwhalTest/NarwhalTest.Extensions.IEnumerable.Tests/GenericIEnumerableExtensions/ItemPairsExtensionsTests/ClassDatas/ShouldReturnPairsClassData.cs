using NarwhalTest.Extensions.IEnumerable.Tests.GenericIEnumerableExtensions.ItemPairsExtensionsTests.TestTypes;
using System.Collections;
using System.Collections.Generic;

namespace NarwhalTest.Extensions.IEnumerable.Tests.GenericIEnumerableExtensions.ItemPairsExtensionsTests.ClassDatas
{
    internal class ShouldReturnPairsClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
            new List<GetAllPairsTestType>
            {
                new GetAllPairsTestType(1,"test1"),
                new GetAllPairsTestType(2,"test2"),
            },
            new List<(GetAllPairsTestType, GetAllPairsTestType)>()
            {
                new (new GetAllPairsTestType(1,"test1"), new GetAllPairsTestType(2,"test2")),
            }
            };
            yield return new object[]
            {
                new List<GetAllPairsTestType>
                {
                    new GetAllPairsTestType(1,"test1"),
                    new GetAllPairsTestType(2,"test2"),
                    new GetAllPairsTestType(3,"test3"),
                    new GetAllPairsTestType(1,"test4")
                },
                new List<(GetAllPairsTestType, GetAllPairsTestType)>()
                {
                    new (new GetAllPairsTestType(1,"test1"), new GetAllPairsTestType(2,"test2")),
                    new (new GetAllPairsTestType(1,"test1"), new GetAllPairsTestType(3,"test3")),

                    new (new GetAllPairsTestType(2,"test2"), new GetAllPairsTestType(3,"test3")),
                    new (new GetAllPairsTestType(2,"test2"), new GetAllPairsTestType(1,"test4")),

                    new (new GetAllPairsTestType(3,"test3"), new GetAllPairsTestType(1,"test4")),
                }
            };
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
    }
}