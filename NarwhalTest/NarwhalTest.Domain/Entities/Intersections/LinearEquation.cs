namespace NarwhalTest.Domain.Entities.Intersections
{
    public class LinearEquation
    {
        public LinearEquation(double variation, double origin)
        {
            Variation = variation;
            Origin = origin;
            IsStaticXCoordinate = false;
        }
        public LinearEquation(double x)
        {
            X = x;
            IsStaticXCoordinate= true;
        }
        public bool IsStaticXCoordinate { get; set; }
        public double Variation { get; set; }
        public double Origin { get; set; }
        public double X { get; set; }

        public double CalculateYFromX(double x)
        {
            return Variation * x + Origin;
        }
    }
}