using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

			IEnumerable<int> positiveSquaresQuery =
			from positiveSquare in n
			where positiveSquare > 0
			select positiveSquare * positiveSquare;

			foreach (var number in positiveSquaresQuery)
			{
				Console.WriteLine(number);
			}

			var positiveSquaresWithLambda = n.Where(y => y > 0).Select(y => y * y);

			Console.ReadLine();
		}
	}
}
