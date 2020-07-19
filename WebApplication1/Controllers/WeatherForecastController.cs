using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private readonly IGuidService guidService;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(IGuidService guidService,ILogger<WeatherForecastController> logger)
        {
            this.guidService = guidService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await this.guidService.GetGuid();
           
            return Ok(result);
        }
    }
}
