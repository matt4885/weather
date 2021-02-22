using Weather.Models;
using Microsoft.EntityFrameworkCore;

namespace Weather.Repo.Interfaces
{
    public class WeatherContext : DbContext
    {
        private readonly DbContextOptions<WeatherContext> _dbContext;
        public WeatherContext(DbContextOptions<WeatherContext> dbContext)
        {
            _dbContext = dbContext;
        }
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    }
}