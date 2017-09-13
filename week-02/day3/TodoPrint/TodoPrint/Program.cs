using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string  todoText =   "My todo:\n  - Buy milk\n  - Download games\n\t  - Diablo";

            Console.WriteLine(todoText);
            Console.ReadLine();
        }
    }
}
