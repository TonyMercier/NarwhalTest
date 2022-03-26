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
    }
}