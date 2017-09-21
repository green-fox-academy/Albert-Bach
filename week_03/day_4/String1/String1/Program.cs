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
            Console.ReadKey();

        }

        public static string Letterchanger(string word)
        {
            string result;
            int inputlength = word.Length;

            if (inputlength == 0)
            {
                return "";
            }
            else
            {
                if (word[0] == 'x')
                {
                    result = "y";
                    return result + Letterchanger(word.Substring(1));
                }
                else
                {
                    return word[0] + Letterchanger(word.Substring(1));
                }

            }

        }
    }
}

