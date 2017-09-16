using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down a number!");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Write down another number!");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("The bigger number is: " + number1);
            }
            else
            {
                Console.WriteLine("The bigger number is: " + number2);
            }
            Console.ReadLine();

        }
    }
}
