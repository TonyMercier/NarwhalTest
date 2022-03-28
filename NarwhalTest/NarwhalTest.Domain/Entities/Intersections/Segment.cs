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
            //if the segment goes straight up (no variation in Latitude) the Equation is simply x = Latitude
            if (Point1.Latitude == Point2.Latitude)
                return new LinearEquation(Point1.Latitude);

            var variation = (Point2.Longitude - Point1.Longitude) / (Point2.Latitude - Point1.Latitude);
            var origin = Point1.Longitude - (Point1.Latitude * variation);
            return new LinearEquation(variation, origin);
        }
        
    }
}