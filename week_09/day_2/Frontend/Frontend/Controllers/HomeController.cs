using Microsoft.AspNetCore.Mvc;


namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [HttpGet]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [Route("/doubling")]
        [HttpGet]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });

        }

        [Route("/greeter")]
        [HttpGet]
        public IActionResult Greeting(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }

            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }

            return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });

        }

        [Route("/appenda/{appendable}")]
        [HttpGet]
        public IActionResult AppendA(string appendable)
        {
            return Json(new { appended = $"{appendable}a" });
        }

        [Route("/appenda/")]
        [HttpGet]
        public IActionResult Append()
        {
            return NotFound();
        }
    }
}
