using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            Console.WriteLine(" Give me 1st integer");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Give me the 2nd integer");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Give me the 3rd integer");
            int third = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Give me the 4th integer");
            int fourth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Give me the 5th integer");
            int fifth = Convert.ToInt32(Console.ReadLine());

            int sum = (first + second + third + fourth + fifth);
            int average = sum / 5;
            Console.WriteLine("Sum: " +sum);
            Console.WriteLine("Average:" + average);
            Console.ReadLine();

        }
    }
}
