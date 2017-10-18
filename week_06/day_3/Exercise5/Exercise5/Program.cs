using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

			var frequenciesOfNumbers =
			from square in n
			orderby square ascending
			group square by square into uniqueSquare
			select new { uniqueSquare.Key, Count = uniqueSquare.Count() };

			var frequency = n.GroupBy(y => y).ToDictionary(y => y.Key, y => y.Count());

			foreach (var nums in frequenciesOfNumbers)
			{
				Console.WriteLine(nums);
			}
			Console.ReadLine();
		}
	}
}
