using System;

namespace _07_TheKnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] board = new string[n,n];
            int br = 0;

            FillingBoard(board, n);

            RemovingKnights(board, n, br);
        }

        private static void RemovingKnights(string[,] board, int n, int br)
        {
            for(int r = 0; r < n; r++)
            {
                for(int c = 0; c < n; c++)
                {

                }
            }
        }

        private static void FillingBoard(string[,] board, int n)
        {
            for (int r = 0; r < n; r++)
            {
                string[] s = Console.ReadLine().Split();
                for (int c = 0; c < n; c++)
                {
                    board[r, c] = s[c];
                }
            }
        }
    }
}
