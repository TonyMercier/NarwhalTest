using NarwhalTest.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NarwhalTest.Application.Tests.Features.VesselTracking.BusinessLogic.VesselDistanceProcessorTests.ClassDatas
{
    public class ShouldReturnInputClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {//empty trackingPoints
                new Vessel(123,
                    new List<TrackingPoint>()
                )
            };
            yield return new object[]
            {//null trackingpoints
                new Vessel(123,null),
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}