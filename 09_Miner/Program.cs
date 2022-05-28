using System;

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
            Tuple<int, int> endPosition = new Tuple<int, int>(0, 0);

            FillingMatrix(matrix, n);

            startPosition = FindingStartPosition(matrix, n, startPosition);
            endPosition = FindingEndPossition(matrix, n, endPosition);

            PlayGame(n, matrix, colloectedCoal, cmnd, startPosition);
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

        private static Tuple<int, int> FindingEndPossition(string[,] matrix, int n, Tuple<int, int> endPosition)
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
        }

        private static void PlayGame(int n, string[,] matrix, int colloectedCoal, string[] cmnd, Tuple<int, int> startPosition)
        {
            Tuple<int, int> currentPossition = startPosition;
            for(int i = 0; i < cmnd.Length; i++)
            {
                
                if (cmnd[i] == "left" && currentPossition.Item2 - 1 >= 0)
                {
                    
                }
                else if(cmnd[i] == "right" && currentPossition.Item2 + 1 < n)
                {

                }
                else if (cmnd[i] == "up" && currentPossition.Item1 - 1 >= 0)
                {

                }
                else if (cmnd[i] == "down" && currentPossition.Item2 + 1 < n)
                {

                }
            }
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
