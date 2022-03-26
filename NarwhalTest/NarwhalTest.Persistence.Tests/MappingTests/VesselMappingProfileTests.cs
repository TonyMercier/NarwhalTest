using AutoMapper;
using DeepEqual.Syntax;
using NarwhalService.Client.Dtos;
using NarwhalTest.Domain.Entities;
using NarwhalTest.Persistence.Mappings;
using System;
using System.Collections.Generic;
using Xunit;

namespace NarwhalTest.Persistence.Tests.MappingTests
{
    public class VesselMappingProfileTests
    {
        private readonly MapperConfiguration _mapperConfig;
        private readonly IMapper _mapper;
        public VesselMappingProfileTests()
        {
            _mapperConfig = new MapperConfiguration(cfg => cfg.AddProfile<VesselMappingProfile>());
            _mapper = _mapperConfig.CreateMapper();
        }
        [Theory]
        [ClassData(typeof(VesselMappingProfileTestsClassData))]
        public void ShouldMap(List<TrackingPointDto> input, List<Vessel> expected)
        {
            _mapperConfig.AssertConfigurationIsValid();
            var actual = _mapper.Map<List<Vessel>>(input);
            actual.ShouldDeepEqual(expected);
        }
    }
}