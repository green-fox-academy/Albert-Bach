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
            string todoText = " - Buy milk\n";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("My todo:");
            sb.Append(todoText);
            sb.AppendLine(" - Download games");
            sb.AppendLine("\t - Diablo");

            todoText = sb.ToString();

            Console.WriteLine(todoText);

            Console.ReadKey();
        }
    }
}
