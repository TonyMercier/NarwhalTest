using NarwhalTest.Domain.Entities;

namespace NarwhalTest.Application.Features.VesselTracking.Contracts
{
    public interface IVesselTrackingRepository
    {
        public Task<List<Vessel>> GetVesselTrackingsByDateRange(DateTime? from = null, DateTime? to = null, int? maxNumber = null);
    }
}