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
        }
    }
}
