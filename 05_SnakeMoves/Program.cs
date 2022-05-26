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

            for (int r = 0; r < cols; r++)
            {
                
                if(r % 2 == 1)
                {
                    for(int c = cols-1; c >=0; c--)
                    {
                        matrix[r, c] = snake[index].ToString();
                        index++;
                        if(index >= snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
                else
                {
                    for (int c = 0; c < cols; c++)
                    {
                        matrix[r, c] = snake[index].ToString();
                        index++;
                        if (index >= snake.Length)
                        {
                            index = 0;
                        }
                    }
                }
            }
        }
    }
}
