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
            var homeViewModel = new HomeViewModel();
            homeViewModel.accounts.Add(homeViewModel.bankAccount1);
            homeViewModel.accounts.Add(homeViewModel.bankAccount2);
            homeViewModel.accounts.Add(homeViewModel.bankAccount3);
            homeViewModel.accounts.Add(homeViewModel.bankAccount4);
            homeViewModel.accounts.Add(homeViewModel.bankAccount5);

            return View(homeViewModel);

        }
    }
}