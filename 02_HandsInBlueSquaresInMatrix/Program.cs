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
            int br = 0;

            string[,] matrix = new string[rows, cols];

            FillMatrix(matrix, rows, cols);

            SearchingTheMatrix(matrix, rows, cols, br);
        }

        private static void SearchingTheMatrix(string[,] matrix, int rows, int cols, int br)
        {
            for(int r = 0; r < rows-1; r++)
            {
                for(int c = 0; c < cols-1; c++)
                {

                }
            }
        }

        private static void FillMatrix(string[,] matrix, int rows, int cols)
        {
            for (int r = 0; r < rows; r++)
            {
                string[] row = Console.ReadLine().Split(' '); 

                for (int c = 0; c < cols; c++)
                {
                    matrix[r, c] = row[c];
                }
            }
        }
    }
}
