using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
	class Program
	{
		static void Main(string[] args)
		{
			string word = "characters";

			var frequencyOfCharacters = 
			from character in word
			group character by character into chars
			select new { chars.Key, Count = chars.Count() };

			var frequency = word.GroupBy(y => y).ToDictionary(y => y.Key, y => y.Count());

			foreach (var letter in frequency)
			{
				Console.WriteLine(letter);
			}
			Console.ReadLine();
		}
	}
}
