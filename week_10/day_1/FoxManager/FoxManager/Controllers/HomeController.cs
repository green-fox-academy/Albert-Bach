using FoxManager.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace FoxManager.Controllers
{
    public class HomeController : Controller
    {
        FoxManagerRepository FoxManagerRepository;

        public HomeController(FoxManagerRepository foxManagerRepository)
        {
            FoxManagerRepository = foxManagerRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
