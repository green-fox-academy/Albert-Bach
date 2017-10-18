using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
			var startsA = 
			from word in cities
			where word.StartsWith("A")
			where word.EndsWith("I")
			select word;

			var startsAWithLambda = cities.Where(y => y.StartsWith("A")).Where(y => y.EndsWith("I"));

			foreach (var item in startsAWithLambda)
			{
				Console.WriteLine(item);
			}
			Console.ReadLine();
		}
	}
}
