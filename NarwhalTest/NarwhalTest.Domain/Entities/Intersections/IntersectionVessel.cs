namespace NarwhalTest.Domain.Entities.Intersections
{
    public class IntersectionVessel
    {
        public IntersectionVessel(int id, DateTime intersectionArrivalTime)
        {
            Id = id;
            IntersectionArrivalTime = intersectionArrivalTime;
        }

        public int Id { get; set; }
        public DateTime IntersectionArrivalTime { get; set; }
    }
}