using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
	class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			int carNumber = 256;
			List<Car> carList = new List<Car>();
			int randomTypeMax = Enum.GetValues(typeof(CarType)).Length;
			int randomColorMax = Enum.GetValues(typeof(CarColor)).Length;

			for (int i = 1; i <= carNumber; i++)
			{
				carList.Add(new Car((CarType)random.Next(randomTypeMax), (CarColor)random.Next(randomColorMax)));
			}

			Console.WriteLine("List of cars: ");

			foreach (var car in carList)
			{
				Console.WriteLine(car.Color.ToString() + " " + car.Type.ToString());
			}
			Console.WriteLine();

			var sameColorQuery = from car in carList
								  group car by new { car.Color } into CarColorQuery
								  select new { CarColorQuery.Key, Count = (from car in CarColorQuery select car).Count() };

			foreach (var car in sameColorQuery)
			{
				Console.WriteLine("Car number in color: with query \n" + car);
			}

			var sameColor = carList.GroupBy(x => x.Color).ToDictionary(x => x.Key, x => x.Count());

			foreach (var car in sameColor)
			{
				Console.WriteLine(car);
			}

			var sameTypeQuery = from car in carList
								 group car by new { car.Type } into CarTypeQuery
								 select new { CarTypeQuery.Key, Count = (from car in CarTypeQuery select car).Count() };

			foreach (var car in sameColorQuery)
			{
				Console.WriteLine("Car number in color: with query \n" + car);
			}

			var sameType = carList.GroupBy(x => x.Type).ToDictionary(x => x.Key, x => x.Count());

			foreach (var car in sameType)
			{
				Console.WriteLine(car);
			}

			var mostFrequentCar = (
			from car in carList
			group car by new { car.Color, car.Type, } into mostFrequent
			orderby mostFrequent.Count() descending
			select new { mostFrequent.Key, Count = (from car in mostFrequent select car).Count() }).Take(1);

			foreach (var car in mostFrequentCar)
			{
				Console.WriteLine(car);
			}

			var mostFrequentCars = carList
				.GroupBy(car => new { Color = car.Color, Type = car.Type })
				.ToDictionary(item => item.Key, item => item.Count())
				.OrderByDescending(item => item.Value)
				.Take(1);
			foreach (var car in mostFrequentCars)
			{
				Console.WriteLine("The most frequent cars are: " + car);
			}

			Console.ReadLine();
		}
	}
}