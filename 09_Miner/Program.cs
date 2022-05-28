using System;
using System.Linq;

namespace _09_Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, n];
            int colloectedCoal = 0;
            string[] cmnd = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Tuple<int, int> startPosition = new Tuple<int, int>(0, 0);
            //Tuple<int, int> endPosition = new Tuple<int, int>(0, 0);
            int countCoal = 0;
            FillingMatrix(matrix, n);

            startPosition = FindingStartPosition(matrix, n, startPosition);
            //endPosition = FindingEndPossition(matrix, n, endPosition);

            countCoal = FindingCoalCount(matrix, n, countCoal);

            PlayGame(n, matrix, colloectedCoal, cmnd, startPosition, countCoal);
        }

        private static int FindingCoalCount(string[,] matrix, int n, int countCoal)
        {
            for (int r = 0; r < n; r++)
            {
                
                for (int c = 0; c < n; c++)
                {
                    if(matrix[r,c] == "c")
                    {
                        countCoal++;
                    }
                }
            }
            return countCoal;
        }

        private static Tuple<int, int> FindingStartPosition(string[,] matrix, int n, Tuple<int, int> startPosition)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if(matrix[r,c] == "s")
                    {
                        Tuple<int, int> sp = new Tuple<int, int>(r, c);
                        startPosition = sp;
                    }
                }
            }
            return startPosition;
        }

        /*private static Tuple<int, int> FindingEndPossition(string[,] matrix, int n, Tuple<int, int> endPosition)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (matrix[r, c] == "e")
                    {
                        Tuple<int, int> ep = new Tuple<int, int>(r, c);
                        endPosition = ep;
                    }
                }
            }
            return endPosition;
        }*/

        private static void PlayGame(int n, string[,] matrix, int colloectedCoal, string[] cmnd, Tuple<int, int> startPosition, int countCoal)
        {
            int currentRow = startPosition.Item1;
            int currentCol = startPosition.Item2;

            for(int i = 0; i < cmnd.Length; i++)
            {
                
                if (cmnd[i] == "left" && currentCol - 1 >= 0)
                {
                    currentCol--;
                }
                else if(cmnd[i] == "right" && currentCol + 1 < n)
                {
                    currentCol++;
                }
                else if (cmnd[i] == "up" && currentRow - 1 >= 0)
                {
                    currentRow--;
                }
                else if (cmnd[i] == "down" && currentRow + 1 < n)
                {
                    currentRow++;
                }

                if (matrix[currentRow, currentCol] == "e")
                {
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    return;
                }
                
                if(matrix[currentRow, currentCol] == "c")
                {
                    colloectedCoal++;
                    matrix[currentRow, currentCol] = "*";
                }

                if (colloectedCoal == countCoal)
                {
                    Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                    return;
                }
            }
            Console.WriteLine($"{countCoal - colloectedCoal} coals left. ({currentRow}, {currentCol})");
        }

        static void FillingMatrix(string[,] matrix, int n)
        {
            
            for(int r = 0; r < n; r++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for(int c = 0; c < n; c++)
                {
                    matrix[r, c] = line[c];
                }
            }
        }
    }
}
