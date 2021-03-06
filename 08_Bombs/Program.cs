using System;
using System.Collections.Generic;

namespace _08_Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            

            FillingTheMatrix(matrix, n);

            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<Tuple<int, int>> bombCoordinates = new List<Tuple<int, int>>();


            FillingCoordinates(line, bombCoordinates);

            ActivatingExplosions(matrix, n, line, bombCoordinates);

            FindingLiveCells(matrix);
            FindingSumOfCells(matrix);

            PrintTheMatrix(matrix, n);
        }

        private static void FindingSumOfCells(int[,] matrix)
        {
            int sumOfLiveCells = 0;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r, c] >= 0)
                    {
                        sumOfLiveCells += matrix[r,c];
                    }
                }
            }

            Console.WriteLine($"Sum: {sumOfLiveCells}");
        }

        static void FindingLiveCells(int[,] matrix)
        {
            int liveCellsLeft = 0;

            for(int r = 0; r < matrix.GetLength(0); r++)
            {
                for(int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r,c] > 0)
                    {
                        liveCellsLeft++;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {liveCellsLeft}");
        }



        private static void PrintTheMatrix(int[,] matrix, int n)
        {
            for(int r = 0; r < n; r++)
            {
                for(int c = 0; c < n; c++)
                {
                    Console.Write($"{matrix[r, c]} ");
                }
                Console.WriteLine();
            }
        }

        private static void FillingCoordinates(string[] line, List<Tuple<int, int>> bombCoordinates)
        {
            for(int i = 0; i < line.Length; i++)
            {
                string[] s = line[i].Split(',', StringSplitOptions.RemoveEmptyEntries);
                int cx = int.Parse(s[0]);
                int cy = int.Parse(s[1]);
                Tuple<int, int> currentC = new Tuple<int, int>(cx, cy);
                bombCoordinates.Add(currentC);
            }
        }

        private static void ActivatingExplosions(int[,] matrix, int n, string[] line, List<Tuple<int, int>> bombCoordinates)
        {
            for(int i = 0; i < bombCoordinates.Count; i++)
            {
                int cxB = bombCoordinates[i].Item1;
                int cyB = bombCoordinates[i].Item2;
                int bomb = matrix[cxB, cyB];
                int[] x = { 1, 0, -1, -1, -1,  0,  1, 1 };
                int[] y = { 1, 1,  1,  0, -1, -1, -1, 0 };

                for(int j = 0; j < x.Length; j++)
                {
                    try
                    {
                        if(matrix[cxB + x[j], cyB + y[j]] > 0)
                        {
                            matrix[cxB + x[j], cyB + y[j]] -= bomb;
                        }
                            
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                matrix[cxB, cyB] = 0;
            }
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
