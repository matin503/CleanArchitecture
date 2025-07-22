using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;


namespace CleanArchitecture.WebApi.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureCorse(this IServiceCollection services) =>
        services.AddCors(option =>
        {
            option.AddPolicy("corsPolicy", builder =>
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            );
        });
    public static void ConfigureLoggerService(this IServiceCollection services) =>
        services.AddSingleton<ILoggerService, LoggerService>();
}
