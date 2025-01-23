using Projekt_zaliczeniowy.Facade;

namespace Projekt_zaliczeniowy.Strategy
{
    public class WeatherService : IWeatherService
    {
        public async Task<string> FetchWeatherJsonAsync(string city)
        {
            Logger.Logger.GetInstance().Log($"Fetching weather data for {city}");
            OpenWeatherFacade openWeather = new OpenWeatherFacade();
            return await openWeather.GetWeatherAsync(city);
        }
    }
}
