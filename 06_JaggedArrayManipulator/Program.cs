using System;
using System.Linq;

namespace _06_JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jMatrix = new int[rows][];

            FillingTheJMatrix(jMatrix, rows);

            AnalizingJMatrix(jMatrix, rows);

            string cmnd;

            while((cmnd = Console.ReadLine()) !="End")
            {
                string[] cmndArg = cmnd.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmndArg[0] == "Add")
                {

                }
                else if (cmndArg[1] == "Subtract")
                {

                }
            }

        }

        private static void AnalizingJMatrix(int[][] jMatrix, int rows)
        {
            for(int r = 0; r < rows-1; r++)
            {
                if(jMatrix[r].Length == jMatrix[r+1].Length )
                {
                    for(int c = 0; c < jMatrix[r].Length; c++)
                    {
                        
                        jMatrix[r][c] = jMatrix[r][c] * 2;
                        jMatrix[r + 1][c] = jMatrix[r + 1][c] * 2;
                        
                        
                    }
                }
                else
                {
                    for(int c = 0; c < jMatrix[r].Length; c++)
                    {
                        jMatrix[r] = jMatrix[r].Select(el => el * 2).ToArray();
                        jMatrix[r + 1] = jMatrix[r + 1].Select(el => el * 2).ToArray();
                    }
                    
                }
            }
        }

        private static void FillingTheJMatrix(int[][] jMatrix, int rows)
        {
            for (int r = 0; r < rows; r++)
            {
                int[] sequence = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jMatrix[r] = sequence;
            }
        }
    }
}
