using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorio
{
    class Program
    {
            public static int Factorio(int input)
            {
                for (int i = input; i > 1; i--)
                {
                    input *= (i - 1);
                }
                return input;
            }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorio(5));
            Console.ReadLine();
        }
        
    }
}
