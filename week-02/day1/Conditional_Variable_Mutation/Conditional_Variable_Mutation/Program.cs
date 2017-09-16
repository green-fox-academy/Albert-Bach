using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Variable_Mutation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 24;
            int out1 = 0;

            if (a % 2 == 0)
            {
                out1 = Convert.ToInt32(a + 1);
                Console.WriteLine(out1);
            }

            int b = 13;
            string out2 = "";

            if (10 <= b && b <= 20)
            {
                out2 = "Sweet!";
            }

            else if (b < 10)
            {
                out2 = "More!";
            }
            else
            {
                out2 = "Less!";
            }

            Console.WriteLine(out2);

            int c = 123;
            int credits = 100;
            bool isBonus = false;

            if (50 <= credits && isBonus == false)
            {
                c -= 2;
            }
            else if (50 > credits && isBonus == false)
            {
                c -= 1;
            }
            else if (isBonus == true)
            {
            }
            Console.WriteLine(c);

            int d = 8;
            int time = 120;
            string out3 = "";
            if (d % 4 == 0 && time <= 200)
            {
                out3 = "check";
            }
            else if (time > 200)
            {
                out3 = "Time out";
            }
            else
            {
                out3 = "Run Forest Run!";
            }

            Console.WriteLine(out3);
            Console.ReadLine();
        }
    }
}