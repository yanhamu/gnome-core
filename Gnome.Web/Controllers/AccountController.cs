using Gnome.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Gnome.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly GnomeDbContext context;
        private readonly UserManager<ApplicationUser> usermanager;

        public AccountController(GnomeDbContext context)
        {
            this.context = context;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return new OkObjectResult(new { data = "random data" });
        }
    }
}