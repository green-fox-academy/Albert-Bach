using System;

namespace Comparable
{
	public class Domino : IComparable
	{
		private readonly int[] Values;

		public Domino(int valueA, int valueB)
		{
			this.Values = new int[] { valueA, valueB };
		}

		public int CompareTo(object obj)
		{
			//Domino otherDomino = obj as Domino;
			Domino otherDomino = (Domino)obj;
			return Values[0].CompareTo(otherDomino.Values[0]);
		}

		public override string ToString()
		{
			return Values[0].ToString() + "," + Values[1];
		}

		public int[] GetValues()
		{
			return Values;
		}
	}
}