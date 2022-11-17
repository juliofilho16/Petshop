using Petshop.Configurations;

namespace Petshop
{
    public class Startup : IStartup
    {
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration _configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            _configuration.LoadApplicationConfigurations();

            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            //RepositoriesConfig.ConfigureServices(services);
            //UseCaseConfig.ConfigureServices(services);
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
    public interface IStartup
    {
        IConfiguration _configuration { get; }
        void Configure(WebApplication app, IWebHostEnvironment environment);
        void ConfigureServices(IServiceCollection services);
    }
    public static class StartupExtensions
    {
        public static WebApplicationBuilder UseStartup<TStartup>(this WebApplicationBuilder webApplicationBuilder) where TStartup : IStartup
        {
            var startup = Activator.CreateInstance(typeof(TStartup), webApplicationBuilder.Configuration) as IStartup;

            if (startup == null) throw new ArgumentException("Classe Startup.cs inválida");

            startup.ConfigureServices(webApplicationBuilder.Services);

            var app = webApplicationBuilder.Build();
            startup.Configure(app, app.Environment);

            app.Run();

            return webApplicationBuilder;
        }
    }
}
