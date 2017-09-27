using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class Anagrammas
    {
        public bool IsAnagram(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                return false;
            }
            char[] first = word1.ToLower().ToCharArray();
            char[] second = word2.ToLower().ToCharArray();

            Array.Sort(first);
            Array.Sort(second);

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    return false;
                }
            }
            return true;

        }
    }
}
