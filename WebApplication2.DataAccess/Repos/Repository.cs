using WebApplication2.DataAccess.Context;

namespace WebApplication2.DataAccess.Repos
{
    public class Repository : IRepository
    {
        private readonly WeatherForecastDb _db;

        public Repository(WeatherForecastDb db)
        {
            _db = db;
        }

        public IEnumerable<WeatherForecast> GetAll()
        {
            return _db.WeatherForecasts;
        }
    }

    public interface IRepository
    {
        IEnumerable<WeatherForecast> GetAll();
    }
}
