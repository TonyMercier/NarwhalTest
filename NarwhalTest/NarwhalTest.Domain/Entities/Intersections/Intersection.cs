namespace NarwhalTest.Domain.Entities.Intersections
{
    public class Intersection
    {
        public IntersectionVessel Vessel1 { get; set; }
        public IntersectionVessel Vessel2 { get; set; }
        public IntersectionPoint IntersectionPoint { get; set; }
    }
}