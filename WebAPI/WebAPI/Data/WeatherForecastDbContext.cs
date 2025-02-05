using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data;

public class WeatherForecastDbContext(
    DbContextOptions<WeatherForecastDbContext> options)
    : DbContext(options)
{
}
