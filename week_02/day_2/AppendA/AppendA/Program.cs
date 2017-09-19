using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "kuty";
            appendA (am);
            Console.ReadLine();
        }

        public static void appendA(string am)
        {
            Console.WriteLine(am + "a");

        }
            
    }
}
