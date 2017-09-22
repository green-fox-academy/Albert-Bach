using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"./assets/lorem-ipsum.txt";
            try
            {
                // Reads the content from `lorem-psum.txt` in the `assets` folder line by line to a string List
                String content = File.ReadAllLines(path);
                // Prints the first line of the file
                Console.WriteLine(content[0]);
            }
        }
    }
}

// Write a function that takes a filename as string,
// then returns the number of lines the file contains.
// It should return zero if it can't open the file, and
// should not raise any error.
