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

    public DbSet<MemberObject> Members { get; set; }
    public DbSet<OrderObject> Orders { get; set; }
    public DbSet<OrderDetailObject> OrderDetails { get; set; }
    public DbSet<ProductObject> Products { get; set; }

}
