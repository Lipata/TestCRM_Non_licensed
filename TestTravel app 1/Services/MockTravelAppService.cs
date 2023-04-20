namespace Travel_app_1.TravelApp
{
    public class MockTravelAppService : ITravelAppService
    {
        public Task<List<SelectedArticlesType>> GetSelectedArticles()
        {
            return Task.FromResult<List<SelectedArticlesType>>(new());
        }

        public Task<List<DestinationsType>> GetDestinations()
        {
            return Task.FromResult<List<DestinationsType>>(new());
        }

        public Task<List<ImageSet1Type>> GetImageSet1()
        {
            return Task.FromResult<List<ImageSet1Type>>(new());
        }
    }
}