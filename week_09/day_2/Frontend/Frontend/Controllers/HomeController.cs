using Frontend.Models;
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
        [Route("/appenda/")]
        [HttpGet]
        public IActionResult AppendA(string appendable)
        {
            if (string.IsNullOrEmpty(appendable))
            {
                return NotFound();
            }
            return Json(new { appended = $"{appendable}a" });
        }

        [HttpPost]
        [Route("dountil/{what}")]
        [Route("dountil/")]
        public IActionResult DoUntil([FromBody] DoUntil doUntil, string what)
        {
            if (what == "factor")
            {
                int factorial = 1;
                for (int i = 1; i < doUntil.Until + 1; i++)
                {
                    factorial *= i;
                }
                return Json(new { result = factorial });
            }
            else if (what == "sum")
            {
                int sum = 0;
                for (int i = 1; i < doUntil.Until + 1; i++)
                {
                    sum += i;
                }
                return Json(new { result = sum });
            }
            return Json(new { error = "Please provide a number!" });
        }

        [HttpPost]
        [Route("array")]
        public IActionResult ArrayHandler([FromBody] MyArray myArray)
        {
            if (myArray.Action == "Sum")
            {
                int result = myArray.Sum(myArray.Number);
                return Json(new { result = result });
            }

            if (myArray.Action == "Multiply")
            {
                int result = myArray.Multiply(myArray.Number);
                return Json(new { result = result });
            }

            if (myArray.Action == "Double")
            {
                int[] result = myArray.Double(myArray.Number);
                return Json(new { result = result });
            }
            return Json(new { error = "Please provide what to do with the numbers!" });
        }
    }
}