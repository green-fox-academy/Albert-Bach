using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            int ak = 123;
            Doubling(ak);
            Console.ReadKey();
        }

        public static void Doubling(int ak)
            { 
            Console.WriteLine(ak*2); 
            Console.ReadLine();
            }
    }
}
