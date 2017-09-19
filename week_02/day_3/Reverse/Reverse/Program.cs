using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)

            {
                string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
                reversed= ReverseString(reversed);
                Console.WriteLine(reversed);
                Console.ReadLine();
            }
            static string ReverseString(string str)
            {
                string newstr = "";
                for (int i = 1; i < str.Length; i++)
                {
                    newstr = newstr + str[str.Length - i];
                }
                newstr = newstr + str[0];
                return newstr;
            }
        }
        
}
    

