using Microsoft.AspNetCore.Mvc;


namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		[Route("hello")]
		public ContentResult Hello()
		{
			return Content("Hello World!");
		}
    }
}								