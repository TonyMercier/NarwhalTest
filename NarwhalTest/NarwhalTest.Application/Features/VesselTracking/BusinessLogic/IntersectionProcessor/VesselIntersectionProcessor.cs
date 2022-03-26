using Geolocation;
using NarwhalTest.Domain.Entities;
using NarwhalTest.Domain.Entities.Intersections;
using System.Numerics;

namespace NarwhalTest.Application.Features.VesselTracking.BusinessLogic.IntersectionProcessor
{
    public class VesselIntersectionProcessor
    {
        public List<Intersection> GetIntersections(List<Vessel> vessels)
        {
            var segments = vessels.SelectMany(v => GetSegments(v)).ToList();
            var segmentPairs = GetAllPairs(segments, (seg1, seg2) => seg1.Vessel.Id != seg2.Vessel.Id);
            var intersections = new List<Intersection>();
            foreach (var segmentPair in segmentPairs)
            {
                var intersect = segmentPair.Item1.GetIntersectionPoint(segmentPair.Item2);
                if (intersect is not null)
                {
                    var arrivalTimeVessel1 = GetIntersectionArrivalTime(intersect, segmentPair.Item1);
                    var arrivalTimeVessel2 = GetIntersectionArrivalTime(intersect, segmentPair.Item2);
                    var timeDifference = arrivalTimeVessel2 - arrivalTimeVessel1;
                    var isWithinAnHour = timeDifference.TotalHours <= 1;

                    if (isWithinAnHour)
                    {
                        intersections.Add(new Intersection()
                        {
                            IntersectionPoint = intersect,
                            Vessel1 = new IntersectionVessel(segmentPair.Item1.Vessel.Id, arrivalTimeVessel1),
                            Vessel2 = new IntersectionVessel(segmentPair.Item2.Vessel.Id, arrivalTimeVessel2)
                        });
                    }
                }
            }
            return intersections;
        }
        private DateTime GetIntersectionArrivalTime(IntersectionPoint intersect, Segment segment)
        {
            var distanceToIntersect = GeoCalculator.GetDistance(
                        segment.Point1.Latitude,
                        segment.Point1.Longitude,
                        intersect.Latitude,
                        intersect.Longitude,
                        4,
                        DistanceUnit.Kilometers
                    );

            return segment.Point1.Date.AddHours(distanceToIntersect / segment.Vessel.AverageSpeedInKmH!.Value);
        }
        private List<Segment> GetSegments(Vessel vessel)
        {
            TrackingPoint lastPoint = vessel.Trackings.First();
            return vessel.Trackings.Skip(1).Select(currentPoint =>
            {
                var segment = new Segment(vessel,lastPoint, currentPoint, new Equation(lastPoint,currentPoint)); 
                lastPoint = currentPoint;//Posible reference issue
                return segment;
            }).ToList();
        }

        private IEnumerable<(T, T)> GetAllPairs<T>(List<T> source, Func<T,T,bool>? canPair = null)
        {
            return source
                .SelectMany((val1, i) => 
                    source.Where((val2, j) => i < j && (canPair is null || canPair(val1,val2))),
                    (x, y) => (x, y)
                );
        }
        private class Equation
        {
            public Equation(TrackingPoint point1, TrackingPoint point2)
            {
                Variation = (point2.Longitude - point1.Longitude) / (point2.Latitude - point1.Latitude);
                Origin = point1.Longitude - (point1.Latitude * Variation);
            }
            public double Variation { get; set; }
            public double Origin { get; set; }

            
        }
        private class Segment
        {
            public Segment(Vessel vessel,TrackingPoint point1, TrackingPoint point2, Equation equation)
            {
                Vessel = vessel;
                Point1 = point1;
                Point2 = point2;
                Equation = equation;
            }
            public Vessel Vessel { get; set; }
            public TrackingPoint Point1 { get; set; }
            public TrackingPoint Point2 { get; set;}
            public Equation Equation { get; set; }
            public IntersectionPoint? GetIntersectionPoint(Segment segment2)
            {
                if (Equation.Variation == segment2.Equation.Variation) return null;
                var x = (Equation.Origin - segment2.Equation.Origin) / (segment2.Equation.Variation - Equation.Variation);
                var y = Equation.Variation * x + Equation.Origin;
                //TODO: find a way to ensure we won't get the same intersection
                //twice if the intersection point is equal to one of the vessel's point.
                //For simplicity, they won't be caught at all at the moment
                var intersectionIsWithinVesselsPath = Point1.Latitude < x && x < Point2.Latitude &&
                    Point1.Longitude < y && y < Point2.Longitude &&
                    segment2.Point1.Latitude < x && x < segment2.Point2.Latitude &&
                    segment2.Point1.Longitude < y && y < segment2.Point2.Longitude;
                if (!intersectionIsWithinVesselsPath)
                    return null;
                return new IntersectionPoint()
                {
                    Latitude = x,
                    Longitude = y
                };
            }
        }
    }
}