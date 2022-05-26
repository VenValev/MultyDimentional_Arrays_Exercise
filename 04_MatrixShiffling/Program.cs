using System;

namespace _04_MatrixShiffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] demetions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(demetions[0]);
            int cols = int.Parse(demetions[1]);
            string[,] matrix = new string[rows, cols];

            FillingTheMatrix(matrix, rows, cols);
        }

        private static void FillingTheMatrix(string[,] matrix, int rows, int cols)
        {
            for(int r = 0; r < rows; r++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for(int c = 0; c < cols; c++)
                {
                    matrix[r, c] = line[c];
                }
            }
        }
    }
}
