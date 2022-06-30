using DataAccess.AppConfig;
using Microsoft.Extensions.Configuration;

namespace DataAccess.DbHelper;
public class DbConfiguration
{
    public static class ConfigurationHelper
    {
        public static AppSettings GetAppSettings()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var section = config.GetSection(nameof(AppSettings));
            return section.Get<AppSettings>();
        }
    }
}
