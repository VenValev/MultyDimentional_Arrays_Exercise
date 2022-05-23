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

            sumPrimaryDiagonal = SummingThePrimaryDiagonal(matrix, sumPrimaryDiagonal, sizeOfArray);

            sumSecondaryDiagonal = SummingTheSecondaryDiagonal(matrix, sumSecondaryDiagonal, sizeOfArray);

            Console.WriteLine(Math.Abs(sumPrimaryDiagonal - sumSecondaryDiagonal));

        }

        static int SummingTheSecondaryDiagonal(int[,] matrix, int sumSecondaryDiagonal, int sizeOfArray)
        {
            for (int c = 0, r = sizeOfArray - 1; c < matrix.Length && r >= 0; c++, r--)
            {
                sumSecondaryDiagonal += matrix[r, c];
            }
            return sumSecondaryDiagonal;
        }

        static int SummingThePrimaryDiagonal(int[,] matrix, int sumPrimaryDiagonal, int sizeOfArray)
        {
            for(int cr = 0; cr < sizeOfArray; cr++)
            {
                sumPrimaryDiagonal += matrix[cr,cr];
            }
            return sumPrimaryDiagonal;
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
