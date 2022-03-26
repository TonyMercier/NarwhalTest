namespace NarwhalTest.Exceptions.Exceptions
{
    internal class PropertyNullException : Exception
    {
        public PropertyNullException(params string[] propertyPath) : this(string.Join('.', propertyPath))
        {
        }
        public PropertyNullException(string propertyPath) : base($"Property cannot be null: {propertyPath}")
        {
        }
    }
}