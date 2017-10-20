using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
	class Game
	{
		static void Main(string[] args)
		{
			Deck deck = new Deck();
			
			Console.WriteLine();
			deck.PullFirst();
			Console.WriteLine();
			deck.PullLast();
			Console.WriteLine();
			deck.PullRandom();
			Console.ReadLine();
		}
	}
}
