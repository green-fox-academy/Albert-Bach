using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    public class CountLet
    {
        public Dictionary<char, int> LetterCounter(string word)
        {
            Dictionary<char, int> resultDictionary = new Dictionary<char, int>();
            int counter = 1;
            word.ToCharArray();

            foreach (char letter in word)
            {
                if (!resultDictionary.ContainsKey(letter))
                {
                    resultDictionary.Add(letter, counter);
                }
                else
                {
                   resultDictionary[letter]++;
                }
            }

            return resultDictionary;
        }
    }
}
