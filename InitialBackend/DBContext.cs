using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using System.Management;
using InitialBackend.Interfaces;

namespace InitialBackend
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderElement> OrderElements { get; set; }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => (e.State == EntityState.Added || e.State == EntityState.Modified));

            var now = DateTime.Now;

            Console.WriteLine(entries);

            foreach (var entityEntry in entries)
            {
                if (entityEntry.Entity is TimeTrackedEntity)
                {
                    ((TimeTrackedEntity)entityEntry.Entity).UpdatedAt = now;

                    if (entityEntry.State == EntityState.Added)
                    {
                        ((TimeTrackedEntity)entityEntry.Entity).CreatedAt = now;
                    }
                }
            }

            return base.SaveChanges();
        }
    }
}
