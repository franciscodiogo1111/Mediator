using Mediator.Interface;
using Mediator.Query;
using Mediator.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Mediator.Handlers
{
    public class WeatherForecastHandler : IRequestHandler<WeatherForecastQuery, WeatherForecastResponse>
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;

        public WeatherForecastHandler(IWeatherForecastRepository weatherForecastRepository) => _weatherForecastRepository = weatherForecastRepository;
        public Task<WeatherForecastResponse> Handle(WeatherForecastQuery request, CancellationToken cancellationToken)
        {
            return _weatherForecastRepository.GetAll(request);
        }
    }
}
