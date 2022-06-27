using BusinessObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Contexts;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        IConfigurationRoot configuration = builder.Build();
        var connectionString = configuration.GetSection("AppSettings:ConnectionStrings");
        optionsBuilder.UseSqlServer(connectionString["DefaultConnection"]);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderDetailObject>()
            .HasKey(nameof(OrderDetailObject.OrderId), nameof(OrderDetailObject.ProductId));
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<MemberObject> Members { get; set; }
    public DbSet<OrderObject> Orders { get; set; }
    public DbSet<OrderDetailObject> OrderDetails { get; set; }
    public DbSet<ProductObject> Products { get; set; }

}
