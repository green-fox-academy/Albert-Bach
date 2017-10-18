using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

			IEnumerable<int> oddAvarageQuery =
			from oddAvarage in n
			where oddAvarage % 2 != 0 
			select oddAvarage;

			var oddAvarageWithLambda = n.Where(y => y % 2 != 0).Average();

			Console.WriteLine(oddAvarageQuery.AsQueryable().Average());
			Console.WriteLine(oddAvarageWithLambda);
			Console.ReadLine();
		}
	}
}
