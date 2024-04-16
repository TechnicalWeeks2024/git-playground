using System.Text.Json.Serialization;

namespace WeatherForecastApi;

public readonly struct WeatherForecast
{
    public static readonly WeatherForecast Empty;
    static WeatherForecast()
    {
        Empty = new() { Date = DateOnly.MinValue };
    }
    
    public DateOnly Date { get; init; }
    public int TemperatureC { get; init; }
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}