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
			CarStore carStore = new CarStore();
			carStore.CarFactory();

			foreach (Car car in carStore.cars)
			{
				Console.WriteLine(car.Type);
				Console.WriteLine(car.Color);
			}

			var sameType = carStore.cars.GroupBy(x => x.Type).ToDictionary(x => x.Key, x => x.Count());

			foreach (var car in sameType)
			{
				Console.WriteLine(car);
			}

			var sameColor = carStore.cars.GroupBy(x => x.Color).ToDictionary(x => x.Key, x => x.Count());

			foreach (var car in sameColor)
			{
				Console.WriteLine(car);
			}

			var mostOccuringCar = (
			from car in carStore.cars
			group car by new { car.Type, car.Color } into mostOccuring
			orderby mostOccuring.Count() descending
			select new { mostOccuring.Key, Count = (from car in mostOccuring select car).Count() }).Take(1);

			foreach (var car in mostOccuringCar)
			{
				Console.WriteLine(car);
			}

			Console.ReadLine();
		}
	}
}