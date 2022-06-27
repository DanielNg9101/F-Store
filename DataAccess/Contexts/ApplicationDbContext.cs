using BusinessObject;
using DataAccess.AppConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static DataAccess.AppConfig.DbConfiguration;

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
        modelBuilder.Entity<OrderDetailObject>()
            .HasKey(nameof(OrderDetailObject.OrderId), nameof(OrderDetailObject.ProductId));
        modelBuilder.Entity<MemberObject>()
            .HasData(new MemberObject
            {
                MemberId = 1,
                Email = _settings.AdminAccount.Email,
                Password = _settings.AdminAccount.Password,
                CompanyName= "DanielNg",
                City = "HCM",
                Country = "VN"
            });
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<MemberObject> Members { get; set; }
    public DbSet<OrderObject> Orders { get; set; }
    public DbSet<OrderDetailObject> OrderDetails { get; set; }
    public DbSet<ProductObject> Products { get; set; }

}
