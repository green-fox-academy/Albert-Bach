using CounterApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CounterApp.Controllers
{
    public class HomeController : Controller
    {
		Counter counter;

		public HomeController (Counter counter)
		{
			this.counter = counter;
		}

		[HttpGet]
		[Route ("Index")]
		public IActionResult Index()
        {
            return View(counter);
        }

		[HttpPost]
		[Route("Index")]
		public IActionResult Increase()
		{
			counter.Raise();
			return RedirectToAction("Index");
		}
	}
}