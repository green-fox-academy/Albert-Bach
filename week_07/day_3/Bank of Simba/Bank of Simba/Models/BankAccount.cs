namespace BankOfSimba.Models
{
	public class BankAccount
	{
        private static int id= 0;
        public int Id { get; set; }
		public string Name { get; set; }
		public double Balance { get; set; }
		public string AnimalType { get; set; }
		public bool IsKing { get; set; }
		public bool IsGood { get; set; }

        public BankAccount( string name, double balance, string animaltype, bool isKing, bool isGood)
		{
            Id = id++;
    		Name = name;
			Balance = balance;
			AnimalType = animaltype;
			IsKing = isKing;
			IsGood = isGood;
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