using Gnome.DataAccess;
using Gnome.Services;
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
        private readonly IRandomService service;

        public AccountController(GnomeDbContext context, IRandomService service)
        {
            this.context = context;
            this.service = service;
        }

        [AllowAnonymous]
        [HttpGet()]
        public IActionResult Get()
        {
            var count = context.Accounts.ToList().Count;

            return new OkObjectResult(new { data = count.ToString() + "random data" + service.GetRandom().ToString() });
        }
    }
}