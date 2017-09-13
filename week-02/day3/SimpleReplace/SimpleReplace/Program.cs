using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "In a dishwasher far far away";

           
            Console.WriteLine(example.Replace("dishwasher", "galaxxy"));
            Console.ReadLine();
        }
    }
}
