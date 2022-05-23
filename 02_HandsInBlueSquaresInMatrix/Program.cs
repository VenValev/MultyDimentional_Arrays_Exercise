using System;
using System.Linq;

namespace _02_HandsInBlueSquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(' ');
            int rows = int.Parse(size[0]);
            int cols = int.Parse(size[1]);

            char[,] matrix = new char[rows, cols];

            FillMatrix(matrix, rows, cols);
        }

        private static void FillMatrix(char[,] matrix, int rows, int cols)
        {
            for (int r = 0; r < rows; r++)
            {
                char[] row = Console.ReadLine().ToCharArray(); ;

                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = row[c];
                }
            }
        }
    }
}
