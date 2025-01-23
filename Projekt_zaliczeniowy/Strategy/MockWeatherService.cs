namespace Projekt_zaliczeniowy.Strategy
{
    public class MockWeatherService : IWeatherService
    {
        public Task<string> FetchWeatherJsonAsync(string city)
        {
            Logger.Logger.GetInstance().Log($"Fetching mock weather data for {city}.");

            string json = @"
            {
                ""main"": {
                    ""temp"": 25.0,
                    ""feels_like"": 27.5,
                    ""humidity"": 60
                }
            }";

            return Task.FromResult(json);
        }
    }
}
