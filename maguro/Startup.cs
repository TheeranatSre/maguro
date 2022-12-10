using maguro.Data;
using maguro.Repository.HealthCheck;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace maguro
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private string _sqlConnectionString;

        public void ConfigureServices(IServiceCollection services)
        {
            _sqlConnectionString = Configuration.GetConnectionString("postgres");
            services.AddDbContext<MaguroContext>(option =>
            {
                option.UseNpgsql(_sqlConnectionString);
            });
            services.AddScoped<IHealthCheckRepository, HealthCheckRepository>();
            services.AddCors();
            services.AddControllers();
        }
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapRazorPages();
            app.Run();
        }
    }
}
