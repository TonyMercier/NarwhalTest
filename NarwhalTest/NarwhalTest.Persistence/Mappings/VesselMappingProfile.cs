using AutoMapper;
using NarwhalService.Client.Dtos;
using NarwhalTest.Domain.Entities;

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