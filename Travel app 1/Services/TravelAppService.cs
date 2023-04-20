using System.Text.Json;

namespace Travel_app_1.TravelApp
{
    public class TravelAppService: ITravelAppService
    {
        private readonly IWebHostEnvironment _env;

        public TravelAppService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public async Task<List<SelectedArticlesType>> GetSelectedArticles()
        {
            var options = new JsonSerializerOptions(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var path = _env.WebRootPath + "/static-data/travel-app-selected-articles.json";
            if (!File.Exists(path))
            {
                return new List<SelectedArticlesType>();
            }
            var data = File.ReadAllText(path);
            return await Task.FromResult(JsonSerializer.Deserialize<List<SelectedArticlesType>>(data, options));
        }

        public async Task<List<DestinationsType>> GetDestinations()
        {
            var options = new JsonSerializerOptions(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var path = _env.WebRootPath + "/static-data/travel-app-destinations.json";
            if (!File.Exists(path))
            {
                return new List<DestinationsType>();
            }
            var data = File.ReadAllText(path);
            return await Task.FromResult(JsonSerializer.Deserialize<List<DestinationsType>>(data, options));
        }

        public async Task<List<ImageSet1Type>> GetImageSet1()
        {
            var options = new JsonSerializerOptions(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var path = _env.WebRootPath + "/static-data/travel-app-image-set-1.json";
            if (!File.Exists(path))
            {
                return new List<ImageSet1Type>();
            }
            var data = File.ReadAllText(path);
            return await Task.FromResult(JsonSerializer.Deserialize<List<ImageSet1Type>>(data, options));
        }
    }
}