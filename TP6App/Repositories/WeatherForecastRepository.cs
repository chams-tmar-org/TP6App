using System;
using TP6App.Models;


// WeatherForecastApi/Repositories/WeatherForecastRepository.cs
using System.Collections.Generic;
using System.Linq;


namespace TP6App.Repositories
{

    public interface IWeatherForcastinatRepository
    {

    }
    public class WeatherForecastRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public WeatherForecastRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<WeatherForecast> GetAll()
        {
            return _dbContext.WeatherForecast.ToList();
        }

        public WeatherForecast GetById(int id)
        {
            return _dbContext.WeatherForecast.Find(id);
        }

        public void Add(WeatherForecast weatherForecast)
        {
            _dbContext.WeatherForecast.Add(weatherForecast);
            _dbContext.SaveChanges();
        }

        public void Update(WeatherForecast weatherForecast)
        {
            _dbContext.WeatherForecast.Update(weatherForecast);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var weatherForecast = _dbContext.WeatherForecast.Find(id);
            if (weatherForecast != null)
            {
                _dbContext.WeatherForecast.Remove(weatherForecast);
                _dbContext.SaveChanges();
            }
        }
    }
}