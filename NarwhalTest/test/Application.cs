using MediatR;
using NarwhalTest.Application.Features.VesselTracking.Queries.GetVesselTrackingInfos;
using NarwhalTest.NarwhalServiceClient;

namespace test
{
    public class Application
    {
        private IMediator _mediator;

        public Application(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Run()
        {
            var result = await _mediator.Send(new GetVesselTrackingInfosQuery(from: DateTime.Parse("2018-04-23"), to: DateTime.Parse("2018-04-24")));
        }
    }
}