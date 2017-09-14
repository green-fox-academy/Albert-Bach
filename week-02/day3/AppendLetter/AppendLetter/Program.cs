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

            for (int i = 0; i < far.Count; i++)

            {
                far[i] += ("a");
                Console.WriteLine(far[i]);

            }

            Console.ReadLine();

            
        }
    }
}
