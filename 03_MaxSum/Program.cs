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
            int maxSum = int.MinValue;

            FillingTheMatrix(mainMatrix, rows, cols);

            maxSum = FindingTheMatrix(mainMatrix, rows, cols, wantedMatrix, maxSum);

            
            Console.WriteLine($"Sum = {maxSum}");

            for(int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write($"{wantedMatrix[r, c]} ");
                }
                Console.WriteLine();
            }
                
        }

        private static int FindingTheMatrix(int[,] mainMatrix, int rows, int cols, int[,] wantedMatrix, int maxSum)
        {
            
            for(int i=0; i <= rows - 3; i++)
            {
                for(int j=0; j <= cols - 3; j++)
                {
                    /*int sum = 
                        mainMatrix[i, j] + mainMatrix[i,j+1] + mainMatrix[i, j+2] +
                        mainMatrix[i+1, j] + mainMatrix[i+1, j + 1] + mainMatrix[i+1, j + 2] + 
                        mainMatrix[i+2, j] + mainMatrix[i+2, j + 1] + mainMatrix[i+2, j + 2];*/
                    int sum = 0;
                    sum = SumOfMatrix(mainMatrix, i, j, sum);

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        FillingWantedMatrix(mainMatrix, i, j, wantedMatrix);
                    }
                }
            }
            return maxSum;
        }

        private static void FillingWantedMatrix(int[,] mainMatrix, int i, int j, int[,] wantedMatrix)
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    wantedMatrix[r,c] = mainMatrix[r + i, c + j];
                }
            }
        }

        static int SumOfMatrix(int[,] mainMatrix,int i, int j, int sum)
        {
            for(int r = 0; r < 3; r++)
            {
                for(int c = 0; c < 3; c++)
                {
                    sum += mainMatrix[r + i, c + j];
                }
            }

            return sum;
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
