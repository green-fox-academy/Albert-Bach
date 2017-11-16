using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}