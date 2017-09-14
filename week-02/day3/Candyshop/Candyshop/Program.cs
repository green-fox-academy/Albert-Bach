using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candyshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            list[list.IndexOf(2)] = "Croissant";
            list[list.IndexOf(false)] = "Ice Cream";

            foreach (object sweet in list)

            {
            Console.WriteLine(sweet);
            }

            Console.ReadLine();
        }
    }
}


