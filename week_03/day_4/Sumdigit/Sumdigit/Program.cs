using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumdigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down a number!");
            int number = 0;
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SumDigits(number));
            Console.ReadKey();

            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).
        }
        public static int SumDigits(int number)
        {
            if (number == 0)
            {
                return 0;
            }

            else
            {
                return (number % 10) + SumDigits (number / 10);
            }

        }
        
    }
}
