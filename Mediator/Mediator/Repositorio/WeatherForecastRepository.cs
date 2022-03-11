using Mediator.Interface;
using Mediator.Query;
using Mediator.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediator.Repositorio
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public async Task<WeatherForecastResponse> GetAll(WeatherForecastQuery weatherForecastQuery)
        {
            var rng = new Random();
            return new WeatherForecastResponse() { Date = DateTime.Now, Summary = Summaries[rng.Next(Summaries.Length)], TemperatureC = rng.Next(-20, 55) };
        }
    }
}
