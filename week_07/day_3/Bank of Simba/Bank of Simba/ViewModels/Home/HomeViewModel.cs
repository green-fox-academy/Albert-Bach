using BankOfSimba.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BankOfSimba.ViewModels.Home
{
	public class HomeViewModel
	{

		public List<BankAccount> accounts { get; set; } = new List<BankAccount>();

		public BankAccount bankAccount1 { get; set; } = new BankAccount("Simba", 2000, "Lion");
		public BankAccount bankAccount2 { get; set; } = new BankAccount("Shenzi", 1500, "Hyena");
		public BankAccount bankAccount3 { get; set; } = new BankAccount("Timon", 500, "Meerkat");
		public BankAccount bankAccount4 { get; set; } = new BankAccount("Pumba", 1000, "Warthog");
		public BankAccount bankAccount5 { get; set; } = new BankAccount("Rafiki", 3000, "Monkey");

	}
}