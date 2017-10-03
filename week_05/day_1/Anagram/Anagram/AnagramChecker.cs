using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class AnagramChecker
    {
        static void Main(string[] args)
        {
          //  IsAnagram("addr", "ddra");
        }

        public static bool IsAnagram(String inputString1, String inputString2) 
            => !(String.IsNullOrEmpty(inputString1) || WordProcessor(inputString1) != WordProcessor(inputString2));

        private static String WordProcessor(String inputString)
        {
            char[] array = inputString.Replace(" ", string.Empty).ToLower().ToCharArray();
            Array.Sort(array);
            return new String(array);
        }
    }
}
