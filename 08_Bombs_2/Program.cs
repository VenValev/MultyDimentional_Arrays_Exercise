using System;
using System.Collections.Generic;

namespace _08_Bombs_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];


            FillingTheMatrix(matrix, n);

            string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Queue<Tuple<int, int>> bombCoordinates = new Queue<Tuple<int, int>>();


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
                    if (matrix[r, c] > 0)
                    {
                        sumOfLiveCells += matrix[r, c];
                    }
                }
            }

            Console.WriteLine($"Sum: {sumOfLiveCells}");
        }

        static void FindingLiveCells(int[,] matrix)
        {
            int liveCellsLeft = 0;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r, c] > 0)
                    {
                        liveCellsLeft++;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {liveCellsLeft}");
        }



        private static void PrintTheMatrix(int[,] matrix, int n)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write($"{matrix[r, c]} ");
                }
                Console.WriteLine();
            }
        }

        private static void FillingCoordinates(string[] line, Queue<Tuple<int, int>> bombCoordinates)
        {
            for (int i = 0; i < line.Length; i++)
            {
                string[] s = line[i].Split(',', StringSplitOptions.RemoveEmptyEntries);
                int cx = int.Parse(s[0]);
                int cy = int.Parse(s[1]);
                Tuple<int, int> currentC = new Tuple<int, int>(cx, cy);
                bombCoordinates.Enqueue(currentC);
            }
        }

        private static void ActivatingExplosions(int[,] matrix, int n, string[] line, Queue<Tuple<int, int>> bombCoordinates)
        {
            int count = bombCoordinates.Count;

            for (int i = 0; i < count; i++)
            {
                int cxB = bombCoordinates.Peek().Item1;
                int cyB = bombCoordinates.Peek().Item2;
                
                int[] x = { 1, 0, -1, -1, -1, 0, 1, 1 };
                int[] y = { 1, 1, 1, 0, -1, -1, -1, 0 };
                
                bombCoordinates.Enqueue(new Tuple<int, int>(cxB, cyB));

                if (matrix[cxB, cyB] > 0)
                {
                    bombCoordinates.Dequeue();
                    int bomb = matrix[cxB, cyB];
                    matrix[cxB, cyB] = 0;
                    

                    for (int j = 0; j < x.Length; j++)
                    {
                        try
                        {
                            if (matrix[cxB + x[j], cyB + y[j]] > 0)
                            {
                                matrix[cxB + x[j], cyB + y[j]] -= bomb;
                            }

                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                }

                

            }
        }

        private static void FillingTheMatrix(int[,] matrix, int n)
        {
            for (int r = 0; r < n; r++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = int.Parse(line[c]);
                }
            }
        }
    }
}
