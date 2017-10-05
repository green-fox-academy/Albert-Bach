using System;

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
            garden.Add(flower2);
            garden.Add(tree1);
            garden.Add(tree2);

            garden.GetStatus();
            garden.WaterAdding(40);
            garden.GetStatus();
            garden.WaterAdding(70);
            garden.GetStatus();

            Console.ReadLine();
        }
    }
}
