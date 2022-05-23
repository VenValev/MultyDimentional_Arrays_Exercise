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

            br = SearchingTheMatrix(matrix, rows, cols, br);

            Console.WriteLine(br);
        }

        private static int SearchingTheMatrix(string[,] matrix, int rows, int cols, int br)
        {
            for(int r = 0; r < rows-1; r++)
            {
                for(int c = 0; c < cols-1; c++)
                {
                    string s1 = matrix[r, c];
                    string s2 = matrix[r, c + 1];
                    string s3 = matrix[r + 1, c];
                    string s4 = matrix[r + 1, c + 1];

                    if(s1 == s2 && s1 == s3 && s1 == s4)
                    {
                        br++;
                    }
                }
            }
            return br;
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
