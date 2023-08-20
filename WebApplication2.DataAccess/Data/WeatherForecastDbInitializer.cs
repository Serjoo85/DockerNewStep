using WebApplication2.DataAccess.Context;

namespace WebApplication2.DataAccess.Data
{
    public class WeatherForecastDbInitializer : IDbInitializer
    {
        private readonly WeatherForecastDb _dataContext;
        public WeatherForecastDbInitializer(WeatherForecastDb dataContext)
        {
            _dataContext = dataContext;
        }
        
        public void InitializeDb()
        {
            _dataContext.Database.EnsureDeleted();
            _dataContext.Database.EnsureCreated();
        }
    }

    public interface IDbInitializer
    {
        public void InitializeDb();
    }
}
