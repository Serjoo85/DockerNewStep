using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2
{
    public class WeatherForecast
    {
        [Key]
        public int WeatherId { get; set; }
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }
        [NotMapped]
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}