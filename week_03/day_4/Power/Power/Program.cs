using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseValue = 0;
            int exponentValue = 0;

            Console.WriteLine("Write down the base value!");
            baseValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write down the exponent value!");
            exponentValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Power(baseValue, exponentValue));
            Console.ReadLine();


            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).
        }

        public static int Power(int baseValue, int exponentValue)
        {
            if (exponentValue == 0)
            {
                return 1;
            }
            else
            {
                return baseValue * Power(baseValue, exponentValue - 1);
            }
        }
    }
}
