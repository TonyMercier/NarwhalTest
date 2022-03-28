namespace NarwhalTest.Domain.Entities.Intersections
{
    public class LinearEquation
    {
        public LinearEquation(double variation, double origin)
        {
            Variation = variation;
            Origin = origin;
        }

        public double Variation { get; set; }
        public double Origin { get; set; }
    }
}