using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a word");
            string word = Console.ReadLine();

            string Palindrome = CreateaPalindrome(word);
            Console.WriteLine(Palindrome);
            Console.ReadLine();

        }

        static string CreateaPalindrome(string word)

        {
            string Palindrome = word;
            for (int i = 1; i < word.Length; i++)
            {
                Palindrome = Palindrome + word[word.Length - i];
            }
            Palindrome = Palindrome + word[0];
            return (Palindrome);
        }
    }
}