using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_Indicator
{
    class Program
    {
        static void Main(string[] args)
        { // Write a program that asks for two numbers
            Console.WriteLine(" Write down the number of girls!");
            int girls = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Write down the number of boys!");
            int boys = Convert.ToInt32(Console.ReadLine());
            int peoples = girls + boys;

            if (girls == boys && peoples >= 20)
            {
                Console.WriteLine("The party is excellent!");
            }

            else if (girls != boys && peoples >= 20)
            {
                Console.WriteLine("Quite cool party!");
            }
            else if (peoples < 20)
            {
                Console.WriteLine("Avarage party...");
            }

            else if (girls == 0)             
            {
                Console.WriteLine("Sausage party");
            }
                Console.ReadLine();
        }
    }
}