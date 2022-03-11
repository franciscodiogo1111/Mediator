using Mediator.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediator.Query
{
    public class WeatherForecastQuery : IRequest<WeatherForecastResponse>
    {
    }
}
