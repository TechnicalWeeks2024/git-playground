namespace WeatherForecastApi;

internal sealed class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var startup = new Startup(builder.Services);
        startup.ConfigureServices();
        
        var app = builder.Build();
        startup.Configure(app, app.Environment);
        
        app.Run();
    }
}

