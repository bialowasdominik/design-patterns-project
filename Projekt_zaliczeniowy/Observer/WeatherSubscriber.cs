using Projekt_zaliczeniowy.Factory;

namespace Projekt_zaliczeniowy.Observer
{
    public class WeatherSubscriber : IObserver
    {
        public string SubscriberName { get; }

        public WeatherSubscriber(string name)
        {
            SubscriberName = name;
        }

        public void Update(WeatherData data)
        {
            Logger.Logger.GetInstance().Log($"[{SubscriberName}] Received update: City={data.City}, Temp={data.Temperature}°C, Humidity={data.Humidity}%. Timestamp={data.Timestamp}");
        }

        public void Update(string data)
        {
            Logger.Logger.GetInstance().Log($"[{SubscriberName}] {data}");
        }
    }
}
