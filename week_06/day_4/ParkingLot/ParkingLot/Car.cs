using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
	class Car : CarStore
	{
		public CarType Type;
		public CarColor Color;

		public Car(CarType type, CarColor color)
		{
			Type = type;
			Color = color;
		}
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
}
