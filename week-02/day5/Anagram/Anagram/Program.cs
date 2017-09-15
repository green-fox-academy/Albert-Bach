using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Write a word!");
            string word1 = Console.ReadLine();
            Console.Write("Write another word!");
            string word2 = Console.ReadLine();

            Console.WriteLine(IsAnagram(word1, word2));
            Console.ReadLine();
        }

        private static bool IsAnagram(string word1, string word2)
        {
            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);
            
            return new string(char1) == new string(char2);
           
        }
    }
}
