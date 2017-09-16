using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down a number!");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)

            {
                Console.WriteLine(i + " * " + number + " = " + i * number);
            }

                Console.ReadLine();
        }
    }
}
