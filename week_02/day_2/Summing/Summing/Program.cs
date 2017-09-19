using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summing
{
    class Program
    {
 
        public static int Sum(int n)
        {
            for (int i = n; i > 0; i--)
            {
                n += i - 1;
            }
            return n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(5));

            Console.ReadLine();
        }
    }
}