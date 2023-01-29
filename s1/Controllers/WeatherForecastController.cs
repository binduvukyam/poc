using Microsoft.AspNetCore.Mvc;

namespace poc.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private int iteration = 11;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public String Get()
    {
        _logger.LogDebug($"Debug {iteration}");
        _logger.LogInformation($"Information {iteration}");  
        _logger.LogWarning($"Warning {iteration}");  
        _logger.LogError($"Error {iteration}");  
        _logger.LogCritical($"Critical {iteration}");

        return "Weather from service-1";
    }
}
