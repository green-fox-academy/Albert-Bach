using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLetter
{
    class Program
    {
        static void Main(string[] args)
        {
           var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Add "a" to every string in the far list.

            List<string> words = new string[] { "Hello", "world" }.ToList();
            words.Insert(0, "Well");
            Console.WriteLine(far);
        }
    }
}
