﻿using Geolocation;
using NarwhalTest.Domain.Entities;
using NarwhalTest.Domain.Entities.Intersections;
using NarwhalTest.Extensions.IEnumerable.GenericIEnumerableExtensions;
using NarwhalTest.Extensions.Number.ValidationExtensions;
using System.Numerics;

namespace NarwhalTest.Application.Features.VesselTracking.BusinessLogic.IntersectionProcessor
{
    public class VesselIntersectionProcessor : IVesselIntersectionProcessor
    {
        public List<Intersection> GetIntersections(List<Vessel> vessels, float intersectTresholdInHour = 1)
        {
            var segments = vessels.SelectMany(v => v.GetSegments()).ToList();
            //This would need some work
            var segmentPairs = segments.GetAllPairs((seg1, seg2) => 
                seg1.Vessel.Id != seg2.Vessel.Id && 
                seg1.Point1.Date.AddHours(-intersectTresholdInHour*3) <= seg2.Point2.Date.AddHours(intersectTresholdInHour*3) && 
                seg2.Point1.Date.AddHours(-intersectTresholdInHour*3) <= seg1.Point2.Date.AddHours(intersectTresholdInHour*3)
                
            ).ToList();

            var intersections = new List<Intersection>();
            segmentPairs.ForEach(segmentPair =>
             {
                 var newIntersection = GetIntersectionForSegmentPair(segmentPair, intersectTresholdInHour);
                 if (newIntersection is not null)
                 {
                     lock (intersections)
                     {
                         //This condition prevents the case where the intersection is duplicated when vesselA meets VesselB on one of VesselB's trackingPoint
                         if (!intersections.Any(existingIntersection => existingIntersection ==newIntersection))
                             intersections.Add(newIntersection);
                     }
                 }
             });
            return intersections;
        }
        private Intersection? GetIntersectionForSegmentPair((Segment, Segment) segmentPair, float intersectTresholdInHour)
        {
            var intersect = GetIntersectionPoint(segmentPair.Item1, segmentPair.Item2);
            if (intersect is null)
                return null;

            var arrivalTimeVessel1 = GetIntersectionArrivalTime(intersect, segmentPair.Item1);
            var arrivalTimeVessel2 = GetIntersectionArrivalTime(intersect, segmentPair.Item2);
            var intersectionIsWithinTimeTreshold = Math.Abs((arrivalTimeVessel2 - arrivalTimeVessel1).TotalHours) <= intersectTresholdInHour;

            if (!intersectionIsWithinTimeTreshold)
                return null;

            return new Intersection()
            {
                IntersectionPoint = intersect,
                Vessel1 = new IntersectionVessel(segmentPair.Item1.Vessel.Id, arrivalTimeVessel1),
                Vessel2 = new IntersectionVessel(segmentPair.Item2.Vessel.Id, arrivalTimeVessel2)
            };

        }
        private Domain.Entities.Coordinate? GetIntersectionPoint(Segment segment1, Segment segment2)
        {
            var equation1 = segment1.GetEquation();
            var equation2 = segment2.GetEquation();
            var intersectionIsImpossible =
                (equation1.IsStaticXCoordinate && equation2.IsStaticXCoordinate && equation1.X != equation2.X) || //both boats are going straight up and not at the same latitude
                equation1.Variation == equation2.Variation; //both boats are going in a parallel path
            if (intersectionIsImpossible)
                return null;

            double x;
            double y;
            //Particular case where both boats follow each other not considered
            if (equation1.IsStaticXCoordinate)
            {
                x = equation1.X;
                y = equation2.CalculateYFromX(x);
            }
            else if (equation2.IsStaticXCoordinate)
            {
                x = equation2.X;
                y = equation1.CalculateYFromX(x);
            }
            else
            {
                x = (equation1.Origin - equation2.Origin) / (equation2.Variation - equation1.Variation);
                y = equation1.CalculateYFromX(x);
            }
            var intersectionIsWithinVesselsPath =
                x.IsBetween(segment1.Point1.Latitude, segment1.Point2.Latitude) &&
                x.IsBetween(segment2.Point1.Latitude, segment2.Point2.Latitude) &&
                y.IsBetween(segment1.Point1.Longitude, segment1.Point2.Longitude) &&
                y.IsBetween(segment2.Point1.Longitude, segment2.Point2.Longitude);
            if (!intersectionIsWithinVesselsPath)
                return null;
            return new NarwhalTest.Domain.Entities.Coordinate()
            {
                Latitude = x,
                Longitude = y
            };
        }
        private DateTime GetIntersectionArrivalTime(NarwhalTest.Domain.Entities.Coordinate intersect, Segment segment)
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
    }
}