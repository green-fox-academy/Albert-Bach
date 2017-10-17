using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
	public class Violin : StringedInstrument
	{
		public Violin()
		{
			numberOfStrings = 4;
			Console.Write("Violin is a {0}-stringed instrument that ", numberOfStrings);
			Sound();
		}

		public override void Sound()
		{
			Console.WriteLine("Screech");
		}
	}
}