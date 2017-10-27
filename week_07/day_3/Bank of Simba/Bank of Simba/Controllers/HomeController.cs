using Microsoft.AspNetCore.Mvc;
using BankOfSimba.ViewModels.Home;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        HomeViewModel homeViewModel;

        public HomeController(HomeViewModel homeViewModel)
        {
            this.homeViewModel = homeViewModel;
        }

        [HttpGet]
        [Route("Account")]
        public IActionResult Index()
        {
            return View(homeViewModel);
        }

        [HttpPost]
        [Route("Account")]
        public IActionResult Action(string Name)
        {
            
            homeViewModel.Raise(Name);
            return RedirectToAction("Index");
        }
    }
}