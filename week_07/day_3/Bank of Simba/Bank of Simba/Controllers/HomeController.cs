using Microsoft.AspNetCore.Mvc;
using BankOfSimba.ViewModels.Home;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
		[Route("Simba")]
		public IActionResult Index()
		{
			var homeViewModel = new HomeViewModel();
			
			return View(homeViewModel);
		}
	}
}