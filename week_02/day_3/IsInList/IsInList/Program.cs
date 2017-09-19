using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsInList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };
            var sublist = new List<int> { 4, 8, 12, 16 };
            bool check = true;

            for (int i = 0; i < sublist.Count; i++)

                if (list.Contains(sublist[i]))
                {
                    check = true;
                }

                else {
                    check = false;
                    }

                { Console.WriteLine(check); }

            for (int i = 0; i < sublist.Count; i++)

                if (list.IndexOf(sublist[i]) > (0))
                {
                    check = true;
                }

                else
                {
                    check = false;
                }

                { Console.WriteLine(check); }
            
                  Console.ReadLine();
        }
    }
}

