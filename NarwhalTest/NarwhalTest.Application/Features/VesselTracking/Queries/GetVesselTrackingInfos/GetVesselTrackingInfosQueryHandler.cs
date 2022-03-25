using MediatR;
using NarwhalTest.Application.Features.VesselTracking.Contracts;

namespace NarwhalTest.Application.Features.VesselTracking.Queries.GetVesselTrackingInfos
{
    internal class GetVesselTrackingInfosQueryHandler : IRequestHandler<GetVesselTrackingInfosQuery>
    {
        private readonly IVesselTrackingRepository _vesselTrackingRepository;

        public GetVesselTrackingInfosQueryHandler(IVesselTrackingRepository vesselTrackingRepository)
        {
            _vesselTrackingRepository = vesselTrackingRepository;
        }

        public Task<Unit> Handle(GetVesselTrackingInfosQuery request, CancellationToken cancellationToken)
        {
            var vessels = _vesselTrackingRepository.GetVesselTrackingsByDateRange(request.From, request.To, request.MaxNumber);
        }
    }
}