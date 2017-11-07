using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        //[Route("/doubling")]
        //[HttpGet]
        //public IActionResult Doubling(int input)
        //{
        //    "received": 15;
        //    "result": 30;
        //    return View();
        //}
    }
}
