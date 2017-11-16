using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
	class Program
	{
		static void Main(string[] args)
		{
			var foxList = new List<Fox>();
			var fox1 = new Fox("Alpaga", "green", "pallida");
			var fox2 = new Fox("Oracle", "green", "pallida");
			var fox3 = new Fox("Rabbit", "green", "pallida");
			var fox4 = new Fox("Totoro", "green", "static");
			var fox5 = new Fox("FutureFox", "yellow", "FutureType");
			foxList.Add(fox1);
			foxList.Add(fox2);
			foxList.Add(fox3);
			foxList.Add(fox4);
			foxList.Add(fox5);
		}
	}
}
