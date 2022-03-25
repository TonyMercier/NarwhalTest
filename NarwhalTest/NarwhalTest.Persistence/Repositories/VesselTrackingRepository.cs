using AutoMapper;
using NarwhalService.Client;
using NarwhalTest.Application.Features.VesselTracking.Contracts;
using NarwhalTest.Domain.Entities;

namespace NarwhalTest.Persistence.Repositories
{
    internal class VesselTrackingRepository : IVesselTrackingRepository
    {
        private ITrackingController _trackingController;
        private IMapper _mapper;

        public VesselTrackingRepository(ITrackingController trackingController, IMapper mapper)
        {
            _trackingController = trackingController;
            _mapper = mapper;
        }

        public async Task<List<Vessel>> GetVesselTrackingsByDateRange(DateTime? from = null, DateTime? to = null, int? maxNumber = null)
        {
            var result = await _trackingController.GetTrackingsByDateRange(from,to,maxNumber);
            if (!result.IsSuccessStatusCode)
                throw result.Error!;
            return result!.Content!;
        }
    }
}