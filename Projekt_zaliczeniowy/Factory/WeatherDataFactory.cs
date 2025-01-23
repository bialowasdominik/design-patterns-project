using Newtonsoft.Json;

namespace Projekt_zaliczeniowy.Factory
{
    public abstract class WeatherDataFactory
    {
        public WeatherData CreateWeatherData(string city, string json)
        {
            Logger.Logger.GetInstance().Log($"Creating WeatherData object for city: {city} from JSON.");
            dynamic parsed = JsonConvert.DeserializeObject(json);
            return BuildWeatherData(city, parsed);
        }

        protected abstract WeatherData BuildWeatherData(string city, dynamic parsedJson);
    }
}
