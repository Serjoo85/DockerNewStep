using Microsoft.EntityFrameworkCore;
using WebApplication2.DataAccess.Context;
using WebApplication2.DataAccess.Data;
using WebApplication2.DataAccess.Repos;

namespace WebApplication2
{
    public class Startup
    {
         public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IDbInitializer, WeatherForecastDbInitializer>();
            services.AddDbContext<WeatherForecastDb>(x =>
            {
                x.UseNpgsql("Server=localhost;Port=5432;Database=WeatherForecastDb;UserName=postgres;Password=postgres;");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IDbInitializer dbInitializer)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
            dbInitializer.InitializeDb();
        }
    }
}