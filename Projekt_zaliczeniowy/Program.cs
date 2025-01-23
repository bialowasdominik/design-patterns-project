using Projekt_zaliczeniowy.Decorator;
using Projekt_zaliczeniowy.Factory;
using Projekt_zaliczeniowy.Observer;
using Projekt_zaliczeniowy.Strategy;

namespace Projekt_zaliczeniowy
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Logger.Logger.GetInstance().Log("Starting WeatherApp...");
            IWeatherService weatherService = new WeatherService();

            WeatherDataFactory factory = new SimpleWeatherDataFactory();

            var station = new WeatherStation();
            var subscriberA = new WeatherSubscriber("Dominik");

            station.Subscribe(subscriberA);

            string city = "Warsaw";
            string weatherJson = await weatherService.FetchWeatherJsonAsync(city);

            WeatherData rawData = factory.CreateWeatherData(city, weatherJson);

            var decoratedData = new AdditionalInfoDecorator(rawData);

            station.Notify(decoratedData);
            station.Notify($"Decorated message: {decoratedData.InfoMessage}");

            station.Unsubscribe(subscriberA);

            Logger.Logger.GetInstance().Log("WeatherApp finished.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
