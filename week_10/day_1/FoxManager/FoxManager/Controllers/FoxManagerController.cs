using FoxManager.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace FoxManager.Controllers
{
    public class FoxManagerController : Controller
    {
        FoxManagerRepository FoxManagerRepository;

        public FoxManagerController(FoxManagerRepository foxManagerRepository)
        {
            FoxManagerRepository = foxManagerRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
