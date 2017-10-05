using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden();
            Flower flower1 = new Flower("yellow");
            Flower flower2 = new Flower("blue");
            Tree tree1 = new Tree("purple");
            Tree tree2 = new Tree("orange");

            garden.Add(flower1);

        }
    }
}
