namespace Projekt_zaliczeniowy.Factory
{
    public class SimpleWeatherDataFactory : WeatherDataFactory
    {
        protected override WeatherData BuildWeatherData(string city, dynamic parsedJson)
        {
            float temperature = (float)(parsedJson.main.temp ?? 0);
            float feelsLike = (float)(parsedJson.main.feels_like ?? 0);
            float humidity = (float)(parsedJson.main.humidity ?? 0);

            return new WeatherData
            {
                City = city,
                Temperature = temperature,
                FeelsLike = feelsLike,
                Humidity = humidity,
                Timestamp = DateTime.Now
            };
        }
    }
}
