using Microsoft.AspNetCore.Mvc;
using FirstWebApp.Models;

namespace FirstWebApp.Controllers
{
	[Route("web")]

	public class WebController : Controller
	{
		[Route("greeting")]
		public IActionResult Greeting()
		{
			var greeting = new Greeting()
			{
				Id = 1,
				Content = "World"
			};

			return View(greeting);
		}

	}
}