using System;
using System.Collections;
using System.Collections.Generic;
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

            PlayGame(matrix, startPosition);
        }

        private static void PlayGame(string[,] matrix, Tuple<int, int> startPosition)
        {
            int currRow = startPosition.Item1;
            int currCol = startPosition.Item2;
            string cmnd = Console.ReadLine();
            char[] commands = cmnd.ToCharArray(); 

            for(int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == 'L')
                {
                    matrix[currRow, currCol] = ".";
                    currCol--;
                }
                else if (commands[i] == 'R')
                {
                    matrix[currRow, currCol] = ".";
                    currCol++;
                }
                else if (commands[i] == 'U')
                {
                    matrix[currRow, currCol] = ".";
                    currRow--;
                }
                else if (commands[i] == 'D')
                {
                    matrix[currRow, currCol] = ".";
                    currRow++;
                }

                if (PlayerEscaped(matrix, currRow, currCol))
                {
                    PrintMatrix(matrix);
                    Console.WriteLine($"won: {currRow} {currCol}");
                    break;
                }
                else if (matrix[currRow, currCol] == "B")
                {
                    PrintMatrix(matrix);
                    Console.WriteLine($"dead: {currRow} {currRow}");
                    break;
                }
                else if (BunniesGotPlayer(matrix, currRow, currCol))
                {
                    PrintMatrix(matrix);
                    Console.WriteLine($"dead: {currRow} {currRow}");
                    break;
                }
                
                else
                {
                    matrix[currRow, currCol] = "P";
                }
                
            }
        }

        private static bool PlayerEscaped(string[,] matrix, int currRow, int currCol)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if(currRow >= rows || currCol >= cols || currRow < 0 || currCol < 0)
            {
                return true;
            }
            return false;
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for(int r = 0; r < matrix.GetLength(0); r++)
            {
                for(int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c]);
                }
                Console.WriteLine();
            }
        }

        private static bool BunniesGotPlayer(string[,] matrix, int currRow, int currCol)
        {
            Queue<Tuple<int, int>> bunniesLocation = new Queue<Tuple<int, int>>();

            for(int r = 0; r < matrix.GetLength(0); r++)
            {
                for(int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r,c] == "B")
                    {
                        bunniesLocation.Enqueue(Tuple.Create(r,c));
                    }
                }
            }

            int bunniesCount = bunniesLocation.Count;

            for(int i = 0; i < bunniesCount; i++)
            {
                int[] nextBRow = {1, 0,-1, 0};
                int[] nextBCol = {0, 1, 0,-1};
                int bRow = bunniesLocation.Peek().Item1;
                int bCol = bunniesLocation.Peek().Item2;
                bunniesLocation.Dequeue();

                if(currRow == bRow && currCol == bCol)
                {
                    return true;
                }
                else
                {
                    for(int j = 0; j < nextBCol.Length; j++)
                    {
                        try
                        {
                            if (bRow + nextBRow[j] == currRow && bCol + nextBCol[j] == currCol)
                            {
                                return true;
                            }
                            else
                            {
                                matrix[bRow + nextBRow[j], bCol + nextBCol[j]] = "B";
                            }
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                }
            }
            return false;
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
                string l = Console.ReadLine();
                char[] line = l.ToCharArray();
                for (int c = 0; c < matrixSize[1]; c++)
                {
                    matrix[r, c] = line[c].ToString();
                }
            }
        }
    }
}
