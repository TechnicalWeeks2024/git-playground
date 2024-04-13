using WeatherForecastApi.MockDb;

namespace WeatherForecastApi;

internal sealed class Startup
{
    private IServiceCollection _services;
    
    public Startup(IServiceCollection services)
    {
        _services = services;
    }
    
    public void ConfigureServices()
    {
        // Add services to the container.
        _services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        _services.AddEndpointsApiExplorer();
        _services.AddSwaggerGen();
        _services.AddListDb();
    }
    
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        
        app.UseRouting();
        app.UseHttpsRedirection();
        
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}