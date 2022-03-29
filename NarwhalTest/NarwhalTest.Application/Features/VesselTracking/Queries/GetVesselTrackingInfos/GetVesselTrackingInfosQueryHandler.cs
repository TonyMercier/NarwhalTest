using MediatR;
using NarwhalTest.Application.Features.VesselTracking.BusinessLogic;
using NarwhalTest.Application.Features.VesselTracking.BusinessLogic.IntersectionProcessor;
using NarwhalTest.Application.Features.VesselTracking.Contracts;

namespace NarwhalTest.Application.Features.VesselTracking.Queries.GetVesselTrackingInfos
{
    internal class GetVesselTrackingInfosQueryHandler : IRequestHandler<GetVesselTrackingInfosQuery,GetVesselTrackingInfosResponse>
    {
        private readonly IVesselTrackingRepository _vesselTrackingRepository;
        private readonly IVesselDistanceProcessor _vesselDistanceProcessor;
        private readonly IVesselAverageSpeedProcessor _vesselAverageSpeedProcessor;
        private readonly IVesselIntersectionProcessor _vesselIntersectionProcessor;
        public GetVesselTrackingInfosQueryHandler(IVesselTrackingRepository vesselTrackingRepository, IVesselAverageSpeedProcessor vesselAverageSpeedProcessor, IVesselDistanceProcessor vesselDistanceProcessor, IVesselIntersectionProcessor vesselIntersectionProcessor)
        {
            _vesselTrackingRepository = vesselTrackingRepository;
            _vesselAverageSpeedProcessor = vesselAverageSpeedProcessor;
            _vesselDistanceProcessor = vesselDistanceProcessor;
            _vesselIntersectionProcessor = vesselIntersectionProcessor;
        }

        public async Task<GetVesselTrackingInfosResponse> Handle(GetVesselTrackingInfosQuery request, CancellationToken cancellationToken)
        {
            var vessels = 
                (await _vesselTrackingRepository.GetVesselTrackingsByDateRange(request.From, request.To, request.MaxNumber))
                .Select(_vesselDistanceProcessor.GetVesselWithProcessedDistance)
                .Select(_vesselAverageSpeedProcessor.GetVesselWithProcessedAverageSpeed)
                .ToList();
            
            var intersections = _vesselIntersectionProcessor.GetIntersections(vessels);
            intersections.Count(x => true);
            return new GetVesselTrackingInfosResponse(vessels, intersections); 
        }
        
    }
}