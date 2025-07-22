namespace CleanArchitecture.WebApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCorse(IServiceCollection service) =>
            service.AddCors(option =>
            {
                option.AddPolicy("corsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                );
            });
    }
}
