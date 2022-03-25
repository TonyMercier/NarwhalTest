using NarwhalService.Client;

namespace test
{
    public class Application
    {
        private ITrackingController _trackingController;

        public Application(ITrackingController trackingController)
        {
            this._trackingController = trackingController;
        }

        public async Task Run()
        {
            var trackings =await _trackingController.GetTrackingsByDateRange();
        }
    }
}