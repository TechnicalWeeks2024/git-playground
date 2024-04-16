using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Mvc;
using WeatherForecastApi.MockDb;

namespace WeatherForecastApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IDatabase _db;

    public WeatherForecastController(IDatabase db)
    {
        _db = db;
    }
    
    [HttpGet]
    public IEnumerable<WeatherForecast> GetForecasts() => _db.GetAll();
    
    [HttpGet]
    public IEnumerable<WeatherForecast> GetByDateOnly(string date)
    {
        if (DateOnly.TryParse(date, out var value))
        {
            return _db.GetByDate(value);
        }

        return Enumerable.Empty<WeatherForecast>();
    }
    
    [HttpGet]
    public WeatherForecast GetByDateOnlySingle(string date)
    {
        DateOnly dt;
        
        if (!DateOnly.TryParse(date, out dt))
        {
            return WeatherForecast.Empty;
        }
        
        var result = _db.GetByDate(dt).FirstOrDefault();
        
        return (dt < result.Date || dt == DateOnly.MinValue) 
            ? WeatherForecast.Empty 
            : result;
    }
}