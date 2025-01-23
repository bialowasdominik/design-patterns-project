namespace Projekt_zaliczeniowy.Facade
{
    public class OpenWeatherFacade
    {
        private readonly HttpClient _httpClient;
        private const string _apiKey = "2d1e5773fe3d1dc316f624436f334f1a";
        private const string weatherBaseUrl = "https://api.openweathermap.org/data/2.5/weather";

        public OpenWeatherFacade()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetWeatherAsync(string cityName)
        {
            Logger.Logger.GetInstance().Log("Fetching weather data from OpenWeather API for.");
            string url = $"{weatherBaseUrl}?q={cityName}&units=metric&appid={_apiKey}";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();

            return json;
        }
    }
}
