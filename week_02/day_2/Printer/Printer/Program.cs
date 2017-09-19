using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parameter = { "first", "second", "third", "fourth", "fifth" };
            Printer(parameter);
        }

        public static void Printer(string[] parameter)
        {
            for (int i = 0; i < parameter.Length; i++)
            {

                Console.WriteLine(parameter[i]);
            }
            Console.ReadKey();
        }
    }
}
