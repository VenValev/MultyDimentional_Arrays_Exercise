using System;
using System.Linq;

namespace _10_RadioactiveMutantVampireBunnies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[matrixSize[0], matrixSize[1]];

            FillingTheMatrix(matrix, matrixSize);

            Tuple<int, int> startPosition = new Tuple<int, int>(0, 0);
            startPosition = FindingStartPosition(matrix, matrixSize, startPosition);


        }

        private static Tuple<int, int> FindingStartPosition(string[,] matrix, int[] matrixSize, Tuple<int, int> startPosition)
        {
            for (int r = 0; r < matrixSize[0]; r++)
            {
                for (int c = 0; c < matrixSize[1]; c++)
                {
                    if (matrix[r, c] == "P")
                    {
                        Tuple<int, int> sp = new Tuple<int, int>(r, c);
                        startPosition = sp;
                    }
                }
            }
            return startPosition;
        }
        private static void FillingTheMatrix(string[,] matrix, int[] matrixSize)
        {
            for(int r = 0; r < matrixSize[0]; r++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int c = 0; c < matrixSize[1]; c++)
                {
                    matrix[r, c] = line[c];
                }
            }
        }
    }
}
