namespace NarwhalTest.Extensions.IEnumerable.GenericIEnumerableExtensions
{
    public static class ItemPairsExtensions
    {
        public static IEnumerable<(T, T)> GetAllPairs<T>(this List<T> source, Func<T, T, bool>? canPair = null)
        {
            return source.AsParallel()
                .SelectMany((val1, i) =>
                    source.Where((val2, j) => i < j && (canPair is null || canPair(val1, val2))),
                    (x, y) => (x, y)
                );
        }
    }
}