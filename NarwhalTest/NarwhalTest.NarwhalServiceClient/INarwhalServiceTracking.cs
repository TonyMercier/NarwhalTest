using NarwhalTest.NarwhalServiceClient.Dtos;
using Refit;

namespace NarwhalTest.NarwhalServiceClient
{
    public interface INarwhalServiceTracking
    {
        Task<IEnumerable<TrackingPointDto>> GetTrackingPoints(DateTime? from = null, DateTime? to = null, int? limit = null);
    }
}