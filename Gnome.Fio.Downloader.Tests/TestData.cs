using Gnome.Fio.Downloader.Tests.Services;
using System.IO;
using System.Reflection;

namespace Gnome.Fio.Downloader.Tests
{
    public static class TestData
    {
        public static string GetFilePath(string filename)
        {
            var location = typeof(FioServiceTests).GetTypeInfo().Assembly.Location;
            var dirPath = Path.GetDirectoryName(location);
            return Path.Combine(dirPath, filename);
        }
    }
}
