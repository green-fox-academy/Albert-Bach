using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Write down a word !");
            string word = Console.ReadLine();
            Console.WriteLine(Star(word));
            Console.ReadKey();

        }

        private static string Star(string word)
        {
            if (word.Length == 1)
            {
                return word;
            }
            else
            {
            return word[0] + "*" + Star(word.Substring(1));
            }

            }
    }
}