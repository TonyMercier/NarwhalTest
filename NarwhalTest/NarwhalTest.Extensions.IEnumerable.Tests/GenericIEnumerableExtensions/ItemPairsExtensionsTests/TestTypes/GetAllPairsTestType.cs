namespace NarwhalTest.Extensions.IEnumerable.Tests.GenericIEnumerableExtensions.ItemPairsExtensionsTests.TestTypes
{
    public class GetAllPairsTestType
    {
        public GetAllPairsTestType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}