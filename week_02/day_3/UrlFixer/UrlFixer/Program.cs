using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrlFixer
{
    class Program
    {
        
            public static void Main(string[] args)
            {
            string url = "https//www.reddit.com/r/nevertellmethebots";
            url =url.Replace("bots", "odds");

            
            Console.WriteLine(url.Insert(5, ":"));

            Console.ReadLine();
            }
            
    }
}
