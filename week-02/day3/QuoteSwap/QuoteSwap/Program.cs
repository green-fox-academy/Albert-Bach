using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            string temp = list[2];
            list [2] = list [5];
            list [5] = temp;

            foreach (string quote in list)

            {
               Console.Write(quote +" ");
            }
               Console.ReadLine();
      

        }
    }
}
