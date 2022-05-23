using System;
using System.Linq;

namespace _03_MaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(' ');
            int rows = int.Parse(size[0]);
            int cols = int.Parse(size[1]);
            int[,] mainMatrix = new int[rows, cols];
            int[,] wantedMatrix = new int[3, 3];

            FillingTheMatrix(mainMatrix, rows, cols);
        }

        static void FillingTheMatrix(int[,] matrix, int rows, int cols)
        {
            for (int r = 0; r < rows; r++)
            {
                int[] row = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = row[c];
                }
            }
        }
    }
    
}
