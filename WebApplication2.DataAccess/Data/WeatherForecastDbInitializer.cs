using WebApplication2.DataAccess.Context;

namespace WebApplication2.DataAccess.Data
{
    public class WeatherForecastDbInitializer : IDbInitializer
    {
        private readonly WeatherForecastDb _dataContext;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        public WeatherForecastDbInitializer(WeatherForecastDb dataContext)
        {
            _dataContext = dataContext;
        }
        
        public void InitializeDb()
        {
            _dataContext.Database.EnsureDeleted();
            _dataContext.Database.EnsureCreated();
            _dataContext.AddRange(GetTestData());
            _dataContext.SaveChanges();
        }

        private WeatherForecast[] GetTestData()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    TemperatureC = Random.Shared.Next(-20, 55),
                    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
                })
                .ToArray();
        }
    }

    public interface IDbInitializer
    {
        public void InitializeDb();
    }
}
