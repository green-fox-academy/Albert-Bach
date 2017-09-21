using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down a number");
            int number = 0;
            number= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CountDown(number));
            Console.ReadLine();

        }
        public static int CountDown(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return CountDown(number - 1);
            }
        }

    }
}
