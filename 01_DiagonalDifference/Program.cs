using System;
using System.Linq;

namespace _01_DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeOfArray, sizeOfArray];
            int sumPrimaryDiagonal = 0;
            int sumSecondaryDiagonal = 0;

            FillingTheMatrix(matrix, sizeOfArray);

            SummingThePrimaryDiagonal(matrix, sumPrimaryDiagonal);

            SummingTheSecondaryDiagonal(matrix, sumSecondaryDiagonal);

            Console.WriteLine(Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal));

        }

        private static void SummingTheSecondaryDiagonal(int[,] matrix, int sumSecondaryDiagonal)
        {
            for (int c = 0, r = matrix.Length - 1; c < matrix.Length && r >= 0; c++, r--)
            {
                sumSecondaryDiagonal += matrix[r, c];
            }
        }

        private static void SummingThePrimaryDiagonal(int[,] matrix, int sumPrimaryDiagonal)
        {
            for(int cr = 0; cr < matrix.Length; cr++)
            {
                sumPrimaryDiagonal += matrix[cr,cr];
            }
        }

        static void FillingTheMatrix(int[,] matrix, int sizeOfArray)
        {
            for (int r = 0; r < sizeOfArray; r++)
            {
                int[] row = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                for (int c = 0; c < sizeOfArray; c++)
                {
                    matrix[r, c] = row[c];
                }
            }
        }
    }
}
