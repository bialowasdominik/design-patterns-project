using Projekt_zaliczeniowy.Factory;

namespace Projekt_zaliczeniowy.Observer
{
    public class WeatherStation : IObservable
    {
        private readonly List<IObserver> _subscribers = new List<IObserver>();

        public void Subscribe(IObserver observer)
        {
            if (!_subscribers.Contains(observer))
            {
                _subscribers.Add(observer);
                Logger.Logger.GetInstance().Log("New subscriber added.");
            }
        }

        public void Unsubscribe(IObserver observer)
        {
            if (_subscribers.Contains(observer))
            {
                _subscribers.Remove(observer);
                Logger.Logger.GetInstance().Log("Subscriber removed.");
            }
        }

        public void Notify(WeatherData data)
        {
            foreach (var sub in _subscribers)
            {
                sub.Update(data);
            }
        }

        public void Notify(string data)
        {
            foreach (var sub in _subscribers)
            {
                sub.Update(data);
            }
        }
    }
}
