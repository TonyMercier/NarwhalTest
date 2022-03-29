namespace NarwhalTest.Domain.Entities.Intersections
{
    public class Intersection
    {
        public IntersectionVessel Vessel1 { get; set; }
        public IntersectionVessel Vessel2 { get; set; }
        public Coordinate IntersectionPoint { get; set; }
        public static bool operator ==(Intersection inter1, Intersection inter2)
        {
            return inter1.IntersectionPoint.Latitude == inter2.IntersectionPoint.Latitude &&
                inter1.IntersectionPoint.Longitude == inter2.IntersectionPoint.Longitude &&
                inter1.Vessel1.Id == inter2.Vessel1.Id &&
                inter1.Vessel2.Id == inter2.Vessel2.Id &&
                inter1.Vessel1.IntersectionArrivalTime.Date == inter2.Vessel1.IntersectionArrivalTime.Date &&
                inter1.Vessel2.IntersectionArrivalTime.Date == inter2.Vessel2.IntersectionArrivalTime.Date &&
                inter1.Vessel1.IntersectionArrivalTime.Hour == inter2.Vessel1.IntersectionArrivalTime.Hour &&
                inter1.Vessel2.IntersectionArrivalTime.Hour == inter2.Vessel2.IntersectionArrivalTime.Hour &&
                inter1.Vessel1.IntersectionArrivalTime.Minute == inter2.Vessel1.IntersectionArrivalTime.Minute &&
                inter1.Vessel2.IntersectionArrivalTime.Minute == inter2.Vessel2.IntersectionArrivalTime.Minute &&
                inter1.Vessel1.IntersectionArrivalTime.Second == inter2.Vessel1.IntersectionArrivalTime.Second &&
                inter1.Vessel2.IntersectionArrivalTime.Second == inter2.Vessel2.IntersectionArrivalTime.Second;
        }
        public static bool operator !=(Intersection inter1, Intersection inter2) => !(inter1 == inter2);
    }
}