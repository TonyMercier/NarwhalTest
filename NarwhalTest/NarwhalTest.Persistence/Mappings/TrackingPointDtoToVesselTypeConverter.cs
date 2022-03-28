using AutoMapper;
using NarwhalTest.Domain.Entities;
using NarwhalTest.NarwhalServiceClient.Dtos;

namespace NarwhalTest.Persistence.Mappings
{
    internal class TrackingPointDtoToVesselTypeConverter : ITypeConverter<List<TrackingPointDto>, List<Vessel>>
    {
        public List<Vessel> Convert(List<TrackingPointDto> source, List<Vessel> destination, ResolutionContext context)
        {
            //Groups TrackingPoints by Vessel
            return source
                .GroupBy(x => x.Vessel)
                .Select(x => new Vessel(x.Key, GetTrackingPointsFromDtos(x.ToList(),context.Mapper)))
                .ToList();
        }
        private List<TrackingPoint> GetTrackingPointsFromDtos(List<TrackingPointDto> source, IMapperBase mapper)
        {
            return mapper
                .Map<List<TrackingPoint>>(source)
                .OrderBy(x => x.Date)
                .ToList();
        }
    }
}