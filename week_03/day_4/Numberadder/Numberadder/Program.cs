using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down a number!");
            int number = 0;
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(NumberAdder(number));
            Console.ReadKey();
            //Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
        }
        public static int NumberAdder(int number)
        {
            if ( number == 0 )
            {
                return 0;
            }

            else
            {
                return number + NumberAdder(number - 1);
            }
        }
    }
}
