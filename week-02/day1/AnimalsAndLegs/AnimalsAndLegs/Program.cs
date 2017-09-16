using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers of your chickens:");
            int chickens = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Numbers of your pigs:");
            int pigs = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The ammount of legs are:" + " " + ((chickens * 2) + (pigs * 4)));
            Console.ReadLine();
        }
    }
}
