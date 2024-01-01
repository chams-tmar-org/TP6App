using TP6App.Models;
using TP6App.Repositories;

namespace TP6App.Services
{
    public interface IweatherForecastService
    {
        void  AddWeatherForecast(WeatherForecast weatherForecast);
    }
    public class weatherForecastService
    {
        private readonly WeatherForecastRepository _repository;

        public weatherForecastService(WeatherForecastRepository repository)
        {
            _repository = repository;
        }

        public void AddWeatherForecast(WeatherForecast weatherForecast)
        {
            _repository.Add(weatherForecast);
            _repository.Add(weatherForecast);
        }
    }
}
