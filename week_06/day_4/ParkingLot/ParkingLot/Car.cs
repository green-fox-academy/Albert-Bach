namespace ParkingLot
{
	class Car 
	{
		public CarType Type { get; set; }
		public CarColor Color { get; set; }

		public Car(CarColor color, CarType type)
		{
			Color = color;
			Type = type;
		}

		public Car(CarType Type, CarColor Color)
		{
			this.Type = Type;
			this.Color = Color;
		}

	}

	public enum CarColor
	{
		Black,
		Blue,
		Red,
		Green,
		White,
		Yellow,
		Silver
	}

	public enum CarType
	{
		Audi,
		BMW,
		Mercedes,
		Peugeot,
		Toyota,
		Suzuki,
		Honda,
		Ford,
		Volkswagen
	}

}
