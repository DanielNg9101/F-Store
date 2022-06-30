using static DataAccess.DbHelper.DbConfiguration;

namespace DataAccess.AppConfig;
public class AppSettings
{
    private static AppSettings instance { get; set; } = ConfigurationHelper.GetAppSettings();

    public static AppSettings Instance => instance ??= new AppSettings();

    public DbConfig ConnectionStrings { get; set; }
    public AdminAccount AdminAccount { get; set; }
}
