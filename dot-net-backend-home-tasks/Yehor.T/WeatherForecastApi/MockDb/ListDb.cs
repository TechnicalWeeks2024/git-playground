namespace WeatherForecastApi.MockDb;

internal sealed class ListDb : IDatabase
{
    private static List<WeatherForecast> _db;

    static ListDb()
    {
        _db = new();
        _db.AddRange(Enumerable.Range(0, 30).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55)
        }));
    }

    public IEnumerable<WeatherForecast> GetAll() => _db;

    public IEnumerable<WeatherForecast> GetByDate(DateOnly date)
        => _db.Where(item => item.Date >= date);
}