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
            Console.WriteLine(" Write down a word with a letter x in it!");
            string word = Console.ReadLine();
            Console.WriteLine(Remover(word));
            Console.ReadKey();

        }

        private static string Remover(string word)
        {
            string result;
            int wordlength = word.Length;

            if (wordlength == 0)
            {
                return "";
            }
            else if (word[0] == 'x')
                {
                    result = "";
                    return Remover(word.Substring(1)) + result;
                }
            else
                {
                    return word[0] + Remover(word.Substring(1));
                }

            }
        }
    }
}