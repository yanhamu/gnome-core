using Gnome.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Gnome.Web.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class UserController
    {
        private readonly UserManager<ApplicationUser> manager;

        public UserController(UserManager<ApplicationUser> manager)
        {
            this.manager = manager;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register([FromBody]RegistrationModel model)
        {
            var user = new ApplicationUser()
            {
                UserName = model.Username
            };

            var result = await manager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return new OkResult();
            }
            else
            {
                return new BadRequestObjectResult(string.Join(" ", result.Errors.Select(e => e.Description)));
            }
        }
    }

    public class RegistrationModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
