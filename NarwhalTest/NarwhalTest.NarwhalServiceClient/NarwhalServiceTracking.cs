using Microsoft.Extensions.Options;
using NarwhalTest.NarwhalServiceClient.Dtos;
using NarwhalTest.NarwhalServiceClient.Options;
using RestSharp;

namespace NarwhalTest.NarwhalServiceClient
{
    internal class NarwhalServiceTracking : INarwhalServiceTracking
    {
        private readonly RestClient _restClient;
        public NarwhalServiceTracking(IOptions<NarwhalServiceClientOptions> options)
        {
            _restClient = new RestClient(options.Value.BaseUrl);
        }

        public async Task<IEnumerable<TrackingPointDto>> GetTrackingPoints(DateTime? from = null, DateTime? to = null, int? limit = null)
        {
            var request = new RestRequest("tracking/get", Method.Get);
            if(from is not null)
                request.AddQueryParameter("from", from!.Value.ToShortDateString());
            if(to is not null)
                request.AddQueryParameter("to", to!.Value.ToShortDateString());
            if(limit is not null)
                request.AddQueryParameter("limit", limit!.Value.ToString());
            var response = await _restClient.ExecuteAsync<IEnumerable<TrackingPointDto>>(request);
            if (response.IsSuccessful)
                return response!.Data!;
            throw response!.ErrorException!;
        }
    }
}