using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = 1;
                        Console.Write(matrix[i, j]);
                    }
                    else
                    {
                        matrix[i, j] = 0;
                        Console.Write(matrix[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
