using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
	public class BassGuitar : StringedInstrument
	{
		private int v;

		public BassGuitar()
		{
			numberOfStrings = 4;
			Console.Write("Bass guitar is a {0}-stringed instrument that ", numberOfStrings);
			Sound();
		}

		public BassGuitar(int numberOfStrings)
		{
			this.numberOfStrings = numberOfStrings;
		}

		public override void Sound()
		{
			Console.WriteLine("Duum-duum-duum.");
		}
	}
}