using Gnome.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Gnome.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly GnomeDbContext context;

        public AccountController(GnomeDbContext context)
        {
            this.context = context;
        }

        [AllowAnonymous]
        [HttpGet()]
        public IActionResult Get()
        {
            var x = context.Accounts.ToList();
            return new OkObjectResult(new { data = "random data" + x.Count.ToString() });
        }
    }
}
