using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

			IEnumerable<int> numbersQuery =
				from evenNumbers in n
				where evenNumbers / 2 == 0
				select evenNumbers;
			
			IEnumerable<int> numbersQueryWithLambda = n.Where(y => y % 2 == 0);

			foreach (var number in numbersQueryWithLambda)
			{
				Console.WriteLine(number);
			}

			Console.ReadLine();
		}
	}
}
