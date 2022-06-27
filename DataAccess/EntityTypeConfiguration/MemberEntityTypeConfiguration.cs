using BusinessObject;
using DataAccess.AppConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityTypeConfiguration;
public class MemberEntityTypeConfiguration : IEntityTypeConfiguration<MemberObject>
{
    private AppSettings _settings = AppSettings.Instance;

    public void Configure(EntityTypeBuilder<MemberObject> builder)
    {
        builder
            .HasData(new MemberObject
            {
                MemberId = 1,
                Email = _settings.AdminAccount.Email,
                Password = _settings.AdminAccount.Password,
                CompanyName = "DanielNg",
                City = "HCM",
                Country = "VN"
            });
    }
}
