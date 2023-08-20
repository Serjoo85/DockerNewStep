using Microsoft.EntityFrameworkCore;
using WebApplication2;
using WebApplication2.DataAccess.Context;
using WebApplication2.DataAccess.Data;
using WebApplication2.DataAccess.Repos;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
}
