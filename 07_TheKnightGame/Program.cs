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

            br = RemovingKnights(board, n, br);

            Console.WriteLine(br);
        }

        private static int RemovingKnights(string[,] board, int n, int br)
        {
            for(int r = 0; r < n; r++)
            {
                for(int c = 0; c < n; c++)
                {
                    if (board[r, c] == "K")
                    {
                        if(ChekIfThereIsKnight(board, n, br, r, c))
                        {
                            continue;
                        }
                        else
                        {
                            br++;
                        }
                    }
                }
            }
            return br;
        }

        private static bool ChekIfThereIsKnight(string[,] board, int n, int br, int r, int c)
        {
            int[] rowMove = { 2, 1, -1, -2, -2, -1,  1,  2 };
            int[] colMove = { 1, 2,  2,  1, -1, -2, -2, -1 };
            for(int i = 0; i < n; i++)
            {
                if (r + rowMove[i] < 0 || c + colMove[i] < 0)
                {
                    continue;
                }
                else if(r + rowMove[i] >= n || c + colMove[i] >= n)
                {
                    continue;
                }

            }

            /*if (board[r-2, c-1] != "K" &&
                board[r-2, c+1] != "K" &&
                board[r-1, c-2] != "K" &&
                board[r-1, c+2] != "K" &&
                board[r+1, c-2] != "K" &&
                board[r+1, c+2] != "K" &&
                board[r+2, c-1] != "K" &&
                board[r+2, c+1] != "K")
            {
                return true;
            }
            else
            {
                return false;
            }*/
        }

        private static void FillingBoard(string[,] board, int n)
        {
            for (int r = 0; r < n; r++)
            {
                string s = Console.ReadLine();
                for (int c = 0; c < n; c++)
                {
                    board[r, c] = s[c].ToString();
                }
            }
        }
    }
}
