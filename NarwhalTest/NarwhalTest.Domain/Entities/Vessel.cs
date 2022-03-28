using NarwhalTest.Domain.Entities.Intersections;

namespace NarwhalTest.Domain.Entities
{
    public class Vessel
    {
        public Vessel(int id, List<TrackingPoint> trackings)
        {
            Id = id;
            Trackings = trackings;
        }

        public int Id { get; set; }
        public List<TrackingPoint> Trackings { get; set; }
        public double? DistanceTraveledInKM { get; set; }
        public double? AverageSpeedInKmH { get; set; }
        public List<Segment> GetSegments()
        {
            if (!Trackings.Any()) return new List<Segment>();
            TrackingPoint lastPoint = Trackings.First();
            return Trackings.Skip(1).Select(currentPoint =>
            {
                var segment = new Segment(this, lastPoint, currentPoint);
                lastPoint = currentPoint;
                return segment;
            }).ToList();
        }
    }
}