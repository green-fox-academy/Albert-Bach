using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineBasicInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Albert Bach";
            int age = 26;
            double height = 1.74;
            bool marriage = false;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(height);

            if (marriage)
            {
                Console.WriteLine("marriage");
            }
            else
            {
                Console.WriteLine("not married");
            }
            

            Console.ReadLine();

        }
    }
}
