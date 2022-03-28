namespace NarwhalTest.Extensions.Number.ValidationExtensions
{
    public static class NumberBetweenExtensions
    {
        public static bool IsBetween<TNumber>(this TNumber numberToCheck, TNumber rangeNumber1, TNumber rangeNumber2) where TNumber : IComparable
        {
            var smallerLimit = rangeNumber1.CompareTo(rangeNumber2) < 1 ? rangeNumber1 : rangeNumber2;
            var upperLimit = rangeNumber1.CompareTo(rangeNumber2) < 1 ? rangeNumber2 : rangeNumber1;
            return
                smallerLimit.CompareTo(numberToCheck) <= 0 &&
                upperLimit.CompareTo(numberToCheck) >= 0;
        }
    }
}