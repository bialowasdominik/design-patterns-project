using Projekt_zaliczeniowy.Factory;

namespace Projekt_zaliczeniowy.Decorator
{
    public abstract class WeatherDataDecorator : WeatherData
    {
        protected WeatherData _innerData;

        public WeatherDataDecorator(WeatherData innerData)
        {
            _innerData = innerData;
        }

        public override string City => _innerData.City;
        public override float Temperature => _innerData.Temperature;
        public override float FeelsLike => _innerData.FeelsLike;
        public override float Humidity => _innerData.Humidity;
        public override DateTime Timestamp => _innerData.Timestamp;
    }
}
