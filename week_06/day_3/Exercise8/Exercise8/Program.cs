using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
	class Program
	{
		static void Main(string[] args)
		{
			string word = "London";

			var upperCase =
			from character in word.ToArray()
			where Char.IsUpper(character)
			select character;

			var upperCaseLambda = word.Where(y => char.IsUpper(y));

			foreach (var character in upperCaseLambda)
            {
				Console.WriteLine(character);
			}
			Console.ReadLine();
		}
	}
}
