using AutoMapper;
using NarwhalTest.Persistence.Mappings;
using Xunit;

namespace NarwhalTest.Persistence.Tests.Mappings
{
    public class VesselMappingProfileTests
    {
        [Fact]
        public void ShouldMap()
        {
            var builder = new MapperConfiguration(cfg => cfg.AddProfile<VesselMappingProfile>());
            builder.AssertConfigurationIsValid() //Rendue ici
            
        }
    }
}