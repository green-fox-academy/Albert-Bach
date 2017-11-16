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
            if (doUntil == null || doUntil.Until == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            if (string.IsNullOrEmpty(what))
            {
                return NotFound();
            }
            else if (what == "sum")
            {
                int sum = 0;

                for (int i = 0; i <= doUntil.Until; i++)
                {
                    sum += i;
                }
                return Json(new { result = sum });
            }
            else if (what == "factor")
            {
                int fact = 1;
                fact = (int)doUntil.Until;
                for (int i = (int)doUntil.Until - 1; i >= 1; i--)
                {
                    fact = fact * i;
                }
                return Json(new { result = fact });
            }
            else
            {
                return Json(new { result = 4 });
            }
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