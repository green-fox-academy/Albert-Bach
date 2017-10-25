namespace BankOfSimba.Models
{
	public class BankAccount
	{
		public string Name { get; set; }
		public double Balance { get; set; }
		public string AnimalType { get; set; }

		public BankAccount(string name, double balance, string animaltype)
		{
			Name = name;
			Balance = balance;
			AnimalType = animaltype;
		}

		public BankAccount()
		{
		}
	}


	public enum AnimalType
	{
		Lion,
		Hyena,
		Meerkat,
		Warthog,
		Monkey
	}
}