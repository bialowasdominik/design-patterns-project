using Projekt_zaliczeniowy.Factory;

namespace Projekt_zaliczeniowy.Observer
{
    public interface IObserver
    {
        void Update(WeatherData data);
        void Update(string data);
    }
}
