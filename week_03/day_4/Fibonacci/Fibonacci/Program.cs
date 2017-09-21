using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a Fibonacci number!");
            int number = 0;
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Fibonacci(number));
            Console.ReadLine();
        }

        public static int Fibonacci(int number)
        {
            if (number < 2)
            {
                return number;
            }
            else
            {
                return Fibonacci(number - 2) + Fibonacci(number - 1);
            }
        }
    }
}
