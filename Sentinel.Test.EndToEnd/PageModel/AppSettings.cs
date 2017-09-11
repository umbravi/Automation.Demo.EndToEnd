using System.Collections.Specialized;

namespace Sentinel.Test.EndToEnd.PageModel
{
    internal static class AppSettings
    {
        internal static string TargetBrowser;
        internal static string UrlUnderTest;

        static AppSettings()
        {
            var settings = GetSettings();
            TargetBrowser = settings["targetBrowser"];
            UrlUnderTest = settings["urlUnderTest"];
        }
        
        internal static NameValueCollection GetSettings()
        {
            return System.Configuration.ConfigurationManager.AppSettings;
        }
    }
}