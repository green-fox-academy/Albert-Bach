using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
	class CarStore
	{
		Random random = new Random();
		public List<Car> cars = new List<Car>();

		public void CarFactory()
		{
			for (int i = 1; i <= 256; i++)
			{
				cars.Add(new Car((CarType)random.Next(0, 8), (CarColor)random.Next(0, 6)));
			}
		}
	}
}
