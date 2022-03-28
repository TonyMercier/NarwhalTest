using AutoMapper;
using NarwhalTest.Application.Features.VesselTracking.Contracts;
using NarwhalTest.Domain.Entities;
using NarwhalTest.NarwhalServiceClient;

namespace NarwhalTest.Persistence.Repositories
{
    internal class VesselTrackingRepository : IVesselTrackingRepository
    {
        private INarwhalServiceTracking _trackingController;
        private IMapper _mapper;

        public VesselTrackingRepository(INarwhalServiceTracking trackingController, IMapper mapper)
        {
            _trackingController = trackingController;
            _mapper = mapper;
        }

        public async Task<List<Vessel>> GetVesselTrackingsByDateRange(DateTime? from = null, DateTime? to = null, int? maxNumber = null)
        {
            var result = await _trackingController.GetTrackingPoints();
            return _mapper.Map<List<Vessel>>(result);
        }
    }
}