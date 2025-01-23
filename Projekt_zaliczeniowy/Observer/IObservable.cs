using Projekt_zaliczeniowy.Factory;

namespace Projekt_zaliczeniowy.Observer
{
    public interface IObservable
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void Notify(WeatherData data);
    }
}
