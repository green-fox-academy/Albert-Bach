using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };

            if (List.Contains(7)) 
            {
                Console.WriteLine("Hoorray");
            }
            else
            {
                Console.WriteLine("Nooooo");
            }

            if(List.IndexOf(7) > (0))
            {
                Console.WriteLine("Hoorray");
            }
            else
            {
                Console.WriteLine("Nooooo");
            }

            Console.WriteLine(List.Contains(7) ? "Hoorray" : "Nooooo");
            Console.ReadLine();


        }
    }
}
