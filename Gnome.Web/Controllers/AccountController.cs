using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gnome.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        [HttpGet()]
        public IActionResult Get()
        {
            return new OkObjectResult(new { data = "random data" });
        }
    }
}
