using BusinessObject;
using Test.AppConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Test.Contexts;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        IConfigurationRoot configuration = builder.Build();
        var connectionStrings = configuration.GetSection("ConnectionStrings");
        Console.WriteLine(connectionStrings);
        optionsBuilder.UseSqlServer(connectionStrings["DefaultConnection"]);
    }

    public DbSet<Member> Members { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Product> Products { get; set; }
}
