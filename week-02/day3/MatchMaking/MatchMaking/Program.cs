using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = new List<string>();

            for (int i = 0; i < girls.Count; i++)
            {
                order.Add(girls.ElementAt(i));
                order.Add(boys.ElementAt(i));
            }
            foreach (string s in order)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
