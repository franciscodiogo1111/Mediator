using Mediator.Query;
using Mediator.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Mediator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WeatherForecastController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<WeatherForecastResponse> Get()
        {
            var query = new WeatherForecastQuery();
            return await _mediator.Send(query);
        }
    }
}
