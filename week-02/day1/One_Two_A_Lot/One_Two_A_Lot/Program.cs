using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Two_A_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down a number!");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Not enough");
            }
            else if (number == 1)
            {
                Console.Write("One");
            }
            else if (number == 2) 
            {
                Console.WriteLine("Two");
            }
            else
            {
                Console.WriteLine("A lot");
            }
            Console.ReadLine();
            
        }
    }
}
