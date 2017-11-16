using Anagramm.Models;
using Microsoft.AspNetCore.Mvc;


namespace Anagramm.Controllers
{
    public class HomeController : Controller
    {
        IsAnagramm isAnagramm;

        public HomeController(IsAnagramm isAnagram)
        {
            this.isAnagramm = isAnagram;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}