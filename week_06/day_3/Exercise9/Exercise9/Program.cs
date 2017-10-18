using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
	class Program
	{
		static void Main(string[] args)
		{
			char[] letters = { 'L', 'o', 'n', 'd', 'o', 'n' };

			var tostringWithLambda = String.Join("", letters.Select(o => o.ToString()).ToArray());

			Console.WriteLine(tostringWithLambda);
			Console.ReadLine();
		}
	}
}
