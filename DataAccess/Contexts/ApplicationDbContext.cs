using BusinessObject;
using DataAccess.AppConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

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
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
    }

    public DbSet<MemberObject> Members { get; set; }
    public DbSet<OrderObject> Orders { get; set; }
    public DbSet<OrderDetailObject> OrderDetails { get; set; }
    public DbSet<ProductObject> Products { get; set; }
}
