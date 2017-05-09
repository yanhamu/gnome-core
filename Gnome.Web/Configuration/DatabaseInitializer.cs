using Gnome.DataAccess;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace Gnome.Web.Configuration
{
    public class DatabaseInitializer
    {
        internal static void DataSeed(UserManager<ApplicationUser> userManager, IConfigurationRoot configuration)
        {
            var username = configuration["SystemCredentials:SysUploader:UserName"];
            var password = configuration["SystemCredentials:SysUploader:Password"];
            userManager.CreateAsync(new ApplicationUser() { UserName = username }, password);
        }
    }
}
