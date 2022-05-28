using System;

namespace _09_Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, n];
            int colloectedCoal = 0;
            string[] cmnd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            FillingTheMatrix(matrix, n);

        }

        private static void FillingTheMatrix(string[,] matrix, int n)
        {
            
            for(int r = 0; r < n; r++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for(int c = 0; c < n; c++)
                {

                }
            }
        }
    }
}
