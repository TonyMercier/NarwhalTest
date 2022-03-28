namespace NarwhalTest.NarwhalServiceClient.Dtos
{
    public class TrackingPointDto
    {
        public int Vessel { get; set; }
        public DateTime Date { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}