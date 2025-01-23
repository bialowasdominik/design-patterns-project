using Projekt_zaliczeniowy.Factory;

namespace Projekt_zaliczeniowy.Decorator
{
    public class AdditionalInfoDecorator : WeatherDataDecorator
    {
        public string InfoMessage { get; private set; }

        public AdditionalInfoDecorator(WeatherData data) : base(data)
        {
            InfoMessage = GenerateInfo(data.Temperature);
        }

        private string GenerateInfo(float temperature)
        {
            if (temperature < 0)
                return "It's freezing outside!";
            if (temperature < 15)
                return "It's rather cold.";
            if (temperature < 25)
                return "Moderate temperature.";
            return "Quite hot today!";
        }
    }
}
