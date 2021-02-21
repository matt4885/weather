using System;
using Weather.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Npgsql;

namespace Weather.Repo
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