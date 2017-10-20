using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyPlusOne
{
	class Card
	{

		public Suit cardSuit { get; set; }
		public Rank cardRank { get; set; }

		public Card(Suit suit, Rank rank)
		{
			cardSuit = suit;
			cardRank = rank;
		}

		public override string ToString()
		{
			return string.Format("{0} {1} ", cardSuit, cardRank);
		}

		public enum Color
		{
			red,
			black
		}

		public enum Suit
		{
			club,
			diamond,
			heart,
			spade
		}
		
		public enum Rank
		{
			Two,
			Three,
			Four,
			Five,
			Six,
			Seven,
			Eight,
			Nine,
			Ten,
			Jack,
			Queen,
			King,
			Ace
		}
	}
}
