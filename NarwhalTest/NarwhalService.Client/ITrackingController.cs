using NarwhalService.Client.Dtos;
using Refit;

namespace NarwhalService.Client
{
    public interface ITrackingController
    {
        [Get("/tracking/get")]
        Task<IApiResponse<IEnumerable<TrackingPointDto>>> GetTrackingsByDateRange(DateTime? from = null, DateTime? to = null, int? limit = null);
    }
}