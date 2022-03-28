namespace NarwhalTest.Domain.Entities.Intersections
{
    public class Segment
    {
        public Segment(Vessel vessel, TrackingPoint point1, TrackingPoint point2)
        {
            Vessel = vessel;
            Point1 = point1;
            Point2 = point2;
        }
        public Vessel Vessel { get; set; }
        public TrackingPoint Point1 { get; set; }
        public TrackingPoint Point2 { get; set; }
        public LinearEquation GetEquation()
        {
            //Dirty fix to prevent a divison by 0 when the vessel goes straight and keep the exact same latitude value.
            //Note that in a real life application I would never do this and would instead take some time looking for a viable solution :)
            var div = (Point2.Latitude - Point1.Latitude);
            if (div == 0) 
                div= 0.000000000000000000000000000000000000000000000000001;

            var variation = (Point2.Longitude - Point1.Longitude) / div;
            var origin = Point1.Longitude - (Point1.Latitude * variation);
            return new LinearEquation(variation, origin);
        }
        
    }
}