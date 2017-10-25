using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.ViewModels.Home;
using BankOfSimba.Models;

namespace BankOfSimba.Controllers
{

    public class HomeController : Controller
    {
		[Route("Account")]
        public IActionResult Index()
        {
			return View(new HomeViewModel());
        }
    }
}