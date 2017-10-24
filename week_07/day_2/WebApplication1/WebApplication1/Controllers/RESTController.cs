using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
	[Route("api")]
	public class RESTController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		static int counter = 0;

		[Route("greeting")]
		public IActionResult Greeting(string name)
		{
			return new JsonResult(new { id = ++counter, content = $"Hello, {name} !" });
		}
	}
}