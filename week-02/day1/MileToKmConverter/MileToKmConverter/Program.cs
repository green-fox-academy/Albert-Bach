using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileToKmConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Distance in km:");
            int km =Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("That's" + " "+ (km)  * 0.621371192 + " miles");
            Console.ReadLine();
        }
    }
}
