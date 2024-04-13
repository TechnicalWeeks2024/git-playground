namespace WeatherForecastApi.MockDb;

public interface IDatabase
{
    IEnumerable<WeatherForecast> GetAll();
    IEnumerable<WeatherForecast> GetByDate(DateOnly date);
}