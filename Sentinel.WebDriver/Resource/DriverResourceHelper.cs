using System;
using System.IO;

namespace Sentinel.WebDriver.Resource
{
    internal class DriverResourceHelper
    {
        internal static void CreateChromeDriver()
        {
            WriteFile("chromedriver.exe", Resource1.chromedriver);
        }

        internal static void CreateIeDriver()
        {
            WriteFile("IEDriverServer.exe", Resource1.IEDriverServer);
        }

        internal static void CreateEdgeDriver()
        {
            WriteFile("MicrosoftWebDriver.exe", Resource1.MicrosoftWebDriver);
        }

        internal static void CreateFirefoxDriver()
        {
            WriteFile("geckodriver.exe", Resource1.geckodriver);
        }

        private static void WriteFile(string fullExeName, byte[] resource)
        {
            var path = System.IO.Path.GetDirectoryName(
                System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            var tempExeName = new Uri(Path.Combine(path, fullExeName)).LocalPath;

            if (File.Exists(tempExeName)) return;
            using (var fsDst = new FileStream(tempExeName, FileMode.CreateNew, FileAccess.Write))
            {
                var bytes = resource;

                fsDst.Write(bytes, 0, bytes.Length);
            }
        }
    }
}

