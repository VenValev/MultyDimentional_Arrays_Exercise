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

            startPosition = FillingTheMatrix(matrix, n, startPosition);

            PlayGame(n, matrix, colloectedCoal, cmnd, startPosition);
        }

        private static void PlayGame(int n, string[,] matrix, int colloectedCoal, string[] cmnd, Tuple<int, int> startPosition)
        {
            for(int i = 0; i < cmnd.Length; i++)
            {
                
                if (cmnd[i] == "left")
                {

                }
                else if(cmnd[i] == "right")
                {

                }
                else if (cmnd[i] == "up")
                {

                }
                else if (cmnd[i] == "down")
                {

                }
            }
        }

        static Tuple<int, int> FillingTheMatrix(string[,] matrix, int n, Tuple<int, int> startPosition)
        {
            
            for(int r = 0; r < n; r++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for(int c = 0; c < n; c++)
                {
                    matrix[r, c] = line[c];
                    if (line[c] == "s")
                    {
                        Tuple<int, int> sp = new Tuple<int, int>(r, c);
                        startPosition = sp;
                        
                    }
                }
            }
            return startPosition;
        }
    }
}
