using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Windows.Input;


namespace ASIActivity1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        public double TemperatureC { get; private set; }

        [HttpGet]
        public String Get()
        {
            var msg = "Please add into your URL '/' followed by the four first numbers off the Zip Code";
            return msg;

        }
       
        [HttpGet("{zipcode}")]
        public IEnumerable<WeatherForecast> Get(string zipcode)
        {
            switch (zipcode)
            {
                case "5300":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Date = DateTime.Parse("2020-03-20T00:49:03.1031855+00:00"),
                        City = "Bragança",
                        ZipCode = zipcode,
                        TemperatureC = 12,
                        TemperatureF = 32 + (int)(12 / 0.5556),
                        Summary = "Cloudy",
                    })
                    .ToArray();
                case "4000":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Date = DateTime.Parse("2020-03-20T00:49:03.1031855+00:00"),
                        City = "Porto",
                        ZipCode = zipcode,
                        TemperatureC = 12,
                        TemperatureF = 32 + (int)(12 / 0.5556),
                        Summary = "Rain Shower",
                    })
                    .ToArray();
                case "1000":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Date = DateTime.Parse("2020-03-20T00:49:03.1031855+00:00"),
                        City = "Lisboa",
                        ZipCode = zipcode,
                        TemperatureC = 15,
                        TemperatureF = 32 + (int)(15 / 0.5556),
                        Summary = "Mostly Cloud",
                    })
                    .ToArray();
                case "9000":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Date = DateTime.Parse("2020-03-20T00:49:03.1031855+00:00"),
                        City = "Ilha da Madeira",
                        ZipCode = zipcode,
                        TemperatureC = 13,
                        TemperatureF = 32 + (int)(13 / 0.5556),
                        Summary = "Cloudy",
                    })
                    .ToArray();
                case "3000":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Date = DateTime.Parse("2020-03-20T00:49:03.1031855+00:00"),
                        City = "Coimbra",
                        ZipCode = zipcode,
                        TemperatureC = 13,
                        TemperatureF = 32 + (int)(13 / 0.5556),
                        Summary = "Cloudy",
                    })
                    .ToArray();
                case "2900":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Date = DateTime.Parse("2020-03-20T00:49:03.1031855+00:00"),
                        City = "Setúbal",
                        ZipCode = zipcode,
                        TemperatureC = 14,
                        TemperatureF = 32 + (int)(14 / 0.5556),
                        Summary = "Partly Cloudy",
                    })
                    .ToArray();

                case "2400":
                    return Enumerable.Range(0, 1).Select(index => new WeatherForecast
                    {
                        Date = DateTime.Parse("2020-03-20T00:49:03.1031855+00:00"),
                        City = "Leiria",
                        ZipCode = zipcode,
                        TemperatureC = 13,
                        TemperatureF = 32 + (int)(13 / 0.5556),
                        Summary = "Cloudy",
                    })
                    .ToArray();
            }
            return Enumerable.Range(0, 1).Select(index => new WeatherForecast
            {
                Date = DateTime.Parse("2020-03-19T23:23:03.1031855+00:00"),
                City = "ERROR - City Not Found in Database",
                TemperatureC = null,
                TemperatureF = null,
                ZipCode = "There is no match in Database"
            })
            .ToArray();
        }
    }
}
