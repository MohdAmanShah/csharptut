using Microsoft.EntityFrameworkCore; // To use DbContext
using Microsoft.EntityFrameworkCore.Proxies; // To use UseLazyLoadingProxies()
using Microsoft.EntityFrameworkCore.Diagnostics;// To use LogTo
namespace Northwind.EntityModels;

public class NorthwindDb : DbContext
{

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string databaseFile = "Northwind.db";
        string path = Path.Combine(Directory.GetCurrentDirectory(), databaseFile);
        string connectionString = $"Data Source={path}";
        WriteLine($"Connection: {connectionString}");
        optionsBuilder.UseSqlite(connectionString);

        optionsBuilder.LogTo(WriteLine, new[] { RelationalEventId.CommandExecuting })
#if DEBUG
        .EnableSensitiveDataLogging() // Include SQL parameters
        .EnableDetailedErrors()
#endif
            ;
        optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().Property(category => category.CategoryName).IsRequired().HasMaxLength(15);
        if (Database.ProviderName?.Contains("sqlite") ?? false)
        {
            modelBuilder.Entity<Product>().Property(product => product.Cost).HasConversion<double>();
        }
    }
}