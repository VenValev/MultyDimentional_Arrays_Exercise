using System;

namespace _05_SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimetions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(dimetions[0]);
            int cols = int.Parse(dimetions[1]);
            string[,] matrix = new string[rows, cols];
            string snake = Console.ReadLine();
            int index = 0;

            for (int r = 0; r < rows; r++)
            {
                
                if(r % 2 == 1)
                {
                    for(int c = cols-1; c >=0; c--)
                    {
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                        matrix[r, c] = snake[index].ToString();
                        index++;
                        
                    }
                }
                else
                {
                    for (int c = 0; c < cols; c++)
                    {
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                        matrix[r, c] = snake[index].ToString();
                        index++;
                        
                    }
                }
            }

            PrintMatrix(matrix, rows, cols);
        }

        private static void PrintMatrix(string[,] matrix, int rows, int cols)
        {
            for(int r = 0; r < rows; r ++)
            {
                for(int c = 0; c < cols; c++)
                {
                    Console.Write($"{matrix[r, c]}");
                }
                Console.WriteLine();
            }
        }
    }
}
