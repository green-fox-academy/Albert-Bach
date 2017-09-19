using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus",
            "Neptune" };

            planetList.Insert(5, "Saturn");

            foreach  (string yvyvyvyv in planetList)
            {
                Console.WriteLine(yvyvyvyv);
            }

            Console.Read();
        }
    }
}
