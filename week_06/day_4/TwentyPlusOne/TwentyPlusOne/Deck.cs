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

		public void Initialize()
		{
			cards = new List<Card>();

			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 13; j++)
				{
					cards.Add(new Card() { Suit = (Suit)i, Face = (Face)j });

					if (j <= 8)
						cards[cards.Count - 1].Value = j + 1;
					else
						cards[cards.Count - 1].Value = 10;
				}
			}
		}

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