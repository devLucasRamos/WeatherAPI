using WeatherAPI.OpenWeatherMap;

namespace WeatherAPI.Repositories
{
    public interface IWForecastRepository
    {
        WeatherResponse GetForecast(string city);   
    }
}
