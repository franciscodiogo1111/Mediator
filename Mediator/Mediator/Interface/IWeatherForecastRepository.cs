using Mediator.Query;
using Mediator.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediator.Interface
{
    public interface IWeatherForecastRepository
    {
        Task<WeatherForecastResponse> GetAll(WeatherForecastQuery weatherForecastQuery);
    }
}
