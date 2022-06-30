using BusinessObject;
using DataAccess.AppConfig;
using DataAccess.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts;
public class ApplicationDbContext : DbContext
{
    private static ApplicationDbContext instance;
    public static ApplicationDbContext Instance => instance ??= new ApplicationDbContext();
    private AppSettings _settings = AppSettings.Instance;
    public ApplicationDbContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_settings.ConnectionStrings.DefaultConnection);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MemberEntityTypeConfiguration).Assembly);
    }

    public DbSet<Member> Members { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Product> Products { get; set; }

}
