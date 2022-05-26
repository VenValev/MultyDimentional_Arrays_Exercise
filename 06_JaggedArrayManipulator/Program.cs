using System;
using System.Linq;

namespace _06_JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jMatrix = new int[rows][];

            FillingTheJMatrix(jMatrix, rows);

            AnalizingJMatrix(jMatrix, rows);

        }

        private static void AnalizingJMatrix(int[][] jMatrix, int rows)
        {
            for(int r = 0; r < rows; r++)
            {
                if(jMatrix[r].Length == jMatrix[r+1].Length )
                {
                    for(int c = 0; c < jMatrix[r].Length; c++)
                    {
                        if(r < rows-1)
                        {
                            jMatrix[r][c] = jMatrix[r][c] * 2;
                            jMatrix[r + 1][c] = jMatrix[r + 1][c] * 2;
                        }
                        
                    }
                }
                else
                {
                    for(int c = 0; c < jMatrix[r].Length; c++)
                    {
                        jMatrix[r][c] = jMatrix[r][c] / 2;
                    }
                    
                }
            }
        }

        private static void FillingTheJMatrix(int[][] jMatrix, int rows)
        {
            for (int r = 0; r < rows; r++)
            {
                int[] sequence = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jMatrix[r] = sequence;
            }
        }
    }
}
