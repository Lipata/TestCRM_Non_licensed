namespace Travel_app_1.TravelApp
{
    public interface ITravelAppService
    {
        Task<List<SelectedArticlesType>> GetSelectedArticles();

        Task<List<DestinationsType>> GetDestinations();

        Task<List<ImageSet1Type>> GetImageSet1();
    }
}