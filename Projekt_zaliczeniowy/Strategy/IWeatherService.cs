namespace Projekt_zaliczeniowy.Strategy
{
    public interface IWeatherService
    {
        Task<string> FetchWeatherJsonAsync(string city);
    }
}
