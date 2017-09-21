using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Write down a word with a letter x in it!");
            string word = Console.ReadLine();
            Console.WriteLine(Letterchanger(word));
            Console.ReadLine();

        }

        public static string Letterchanger(string word)
        {
            if (word.Length == 0)
            {
                return "";
            }
            else if (word[0] == 'x')
            {
                return 'y' + Letterchanger(word.Substring(1));
            }
            else
            {
                return word[0] + Letterchanger(word.Substring(1));
            }
        }
    }
}

