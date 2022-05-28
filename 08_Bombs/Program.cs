using System;

namespace _08_Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            FillingTheMatrix(matrix, n);


        }

        private static void FillingTheMatrix(int[,] matrix, int n)
        {
            for(int r = 0; r < n; r++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for(int c = 0; c < n; c++)
                {
                    matrix[r, c] = int.Parse(line[c]);
                }
            }
        }
    }
}
