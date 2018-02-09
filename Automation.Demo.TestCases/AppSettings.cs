using System.IO;
using Microsoft.Extensions.Configuration;

namespace Automation.Demo.TestCases
{
    internal static class AppSettings
    {
        internal static string TargetBrowser;
        internal static string ApplicationUnderTestUrl;
        
        internal static IConfigurationRoot GetConfiguration()
        {
            var settings = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            return settings.Build();
        }
    }
}