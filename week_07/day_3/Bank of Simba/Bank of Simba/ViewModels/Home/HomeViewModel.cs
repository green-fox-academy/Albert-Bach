using BankOfSimba.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BankOfSimba.ViewModels.Home
{
	public class HomeViewModel
	{

		public List<BankAccount> accounts { get; set; } = new List<BankAccount>
		{
		 new BankAccount("Simba", 2000, "Lion", true, true),
		 new BankAccount("Shenzi", 1500, "Hyena", false, false),
		 new BankAccount("Timon", 500, "Meerkat", false, true),
		 new BankAccount("Pumba", 1000, "Warthog", false, true),
		 new BankAccount("Rafiki", 3000, "Monkey", false, true)
		};
	}
}