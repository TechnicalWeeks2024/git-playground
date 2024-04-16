namespace WeatherForecastApi.MockDb;

internal static class ListDbExtensions
{
    public static IServiceCollection AddListDb(this IServiceCollection collection)
        => collection.AddSingleton<IDatabase>(new ListDb());
}