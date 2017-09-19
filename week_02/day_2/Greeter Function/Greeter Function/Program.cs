using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeter_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Greenfox";
            greet(al);
            Console.ReadLine();
        }
            public static void greet(string al)
            {
                Console.WriteLine("Greetings dear," + al);
            }

        

    }
}
