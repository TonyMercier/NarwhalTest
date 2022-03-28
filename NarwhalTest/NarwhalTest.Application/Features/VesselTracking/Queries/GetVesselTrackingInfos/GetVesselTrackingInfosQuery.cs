using MediatR;

namespace NarwhalTest.Application.Features.VesselTracking.Queries.GetVesselTrackingInfos
{
    public class GetVesselTrackingInfosQuery : IRequest<GetVesselTrackingInfosResponse>
    {
        public GetVesselTrackingInfosQuery(DateTime? from=null, DateTime? to = null, int? maxNumber = null)
        {
            From = from;
            To = to;
            MaxNumber = maxNumber;
        }

        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public int? MaxNumber { get; set; }
    }
}