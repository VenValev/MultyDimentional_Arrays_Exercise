using System;

namespace _07_TheKnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] board = new string[n,n];

            for(int r = 0; r < n; r++)
            {
                string[] s = Console.ReadLine().Split();
                for(int c = 0; c < n; c++)
                {
                    board[r,c] = s[c];
                }


            }
        }
    }
}
