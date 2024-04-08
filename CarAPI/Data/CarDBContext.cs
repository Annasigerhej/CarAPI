using Microsoft.EntityFrameworkCore;
using CarAPI.Models;

namespace CarAPI.Data
{
    public class CarDBContext : DbContext
    {
        public CarDBContext(DbContextOptions<CarDBContext> options) : base(options)
        {
        }
        // Add DbSet properties for your entity models here
        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<Make> Makes { get; set; } = null!;
        public DbSet<Model> Models { get; set; } = null!;
        public DbSet<Style> Styles { get; set; } = null!;


    }
}