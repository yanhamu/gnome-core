using Gnome.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Gnome.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly GnomeDbContext context;
        private readonly UserManager<ApplicationUser> usermanager;

        public AccountController(GnomeDbContext context, UserManager<ApplicationUser> usermanager)
        {
            this.context = context;
            this.usermanager = usermanager;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            var x = context.Accounts.ToList();

            var user = this.HttpContext.User;

            return new OkObjectResult(new { data = "random data" + x.Count.ToString() });
        }
    }
}