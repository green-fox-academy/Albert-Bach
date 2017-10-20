using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
	class Deck
	{
		public List<Card> cards = new List<Card>();


		public void PullFirst()
		{
			var firstCard = newCards.FirstOrDefault();
			Console.WriteLine(firstCard);
		}

		public void PullLast()
		{
			var lastCard = newCards.LastOrDefault();
			Console.WriteLine(lastCard);
		}

		public void PullRandom()
		{
			Random random = new Random();
			var randomCard = newCards[random.Next(newCards.Count)];
			Console.WriteLine(randomCard);
		}
	}
}