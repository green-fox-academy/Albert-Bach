﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000
            double a = 10;
            double b = 20;
            double c = 30;

            Console.WriteLine("Surface Area:" + (2 * ((a * b) + (b * c) + (a * c))));
            Console.WriteLine("Volume:" + (a * b * c));
            Console.ReadLine();
        }
    }
}
