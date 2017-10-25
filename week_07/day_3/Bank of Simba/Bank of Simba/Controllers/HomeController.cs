using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;
using System.Collections.Generic;

namespace BankOfSimba.Controllers
{
	public class HomeController : Controller
	{
		[Route("Simba")]
		public IActionResult Index()
		{
			var bankAccount = new BankAccount()
			{
				Name = "Simba",
				Balance = 2000,
				AnimalType = AnimalType.Lion
			};

			return View(bankAccount);
		}
	}
}