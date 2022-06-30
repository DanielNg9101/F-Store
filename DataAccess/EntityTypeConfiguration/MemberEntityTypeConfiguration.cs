using BusinessObject;
using DataAccess.AppConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityTypeConfiguration;
public class MemberEntityTypeConfiguration : IEntityTypeConfiguration<Member>
{
    private AppSettings _settings = AppSettings.Instance;

    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder
            .HasData(new Member
            {
                Id = 1,
                Email = _settings.AdminAccount.Email,
                Password = _settings.AdminAccount.Password,
                CompanyName = "DanielNg",
                City = "HCM",
                Country = "VN"
            },
            new Member
            {
                Id = 2,
                Email = "a",
                Password = "a",
                CompanyName = "DanielNg",
                City = "HCM",
                Country = "VN"
            });
        builder
            .Property(e => e.Id)
            .HasColumnName("MemberId");
    }
}
