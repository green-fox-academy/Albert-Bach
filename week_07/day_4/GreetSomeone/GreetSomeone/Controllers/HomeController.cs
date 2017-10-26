using GreetSomeone.Models;
using Microsoft.AspNetCore.Mvc;

namespace GreetSomeone.Controllers
{
    public class HomeController : Controller
    {
        Name name;

        public HomeController(Name name)
        {
            this.name = name;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View(name);
        }

        [HttpPost]
        [Route("/")]
        public IActionResult ForwardToPage(Name name)
        {

            return RedirectToAction("Greet", name);
        }

        [HttpGet]
        [Route("Greet")]
        public IActionResult Greet(Name name)
        {
            return View(name);
        }
    }
}