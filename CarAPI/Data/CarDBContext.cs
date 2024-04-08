using Microsoft.EntityFrameworkCore;

namespace CarAPI.Data
{
    public class CarDBContext : DbContext
    {
        public CarDBContext(DbContextOptions<CarDBContext> options) : base(options)
        {
        }

        // Add DbSet properties for your entity models here
        // For example:
        // public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity model relationships and constraints here
            // For example:
            // modelBuilder.Entity<Car>()
            //     .HasOne(c => c.Owner)
            //     .WithMany(o => o.Cars)
            //     .HasForeignKey(c => c.OwnerId);
        }
    }
}