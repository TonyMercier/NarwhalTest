using AutoMapper;
using NarwhalTest.Domain.Entities;
using NarwhalTest.NarwhalServiceClient.Dtos;

namespace NarwhalTest.Persistence.Mappings
{
    public class VesselMappingProfile : Profile
    {
        public VesselMappingProfile()
        {
            CreateMap<TrackingPointDto, TrackingPoint>();
            CreateMap<List<TrackingPointDto>, List<Vessel>>()
                .ConvertUsing<TrackingPointDtoToVesselTypeConverter>();
        }
    }
}