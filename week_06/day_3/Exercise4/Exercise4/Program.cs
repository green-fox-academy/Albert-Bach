using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] n = new[] { 3, 9, 2, 8, 6, 5 };

			IEnumerable<int> squaresQuery =
			from square in n
			where square * square > 20
			select square ;

			foreach (var number in squaresQuery)
			{
				Console.WriteLine(number);
			}

			Console.WriteLine();
			
			IEnumerable<int> squaresWithLambda = n.Where(y => y * y > 20);

			foreach (var squares in squaresWithLambda)
			{
				Console.WriteLine(squares);
			}


			Console.ReadLine();
		}
	}
}