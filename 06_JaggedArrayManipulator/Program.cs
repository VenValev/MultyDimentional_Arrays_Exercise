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
                int row = int.Parse(cmndArg[1]);
                int col = int.Parse(cmndArg[2]);
                int value = int.Parse(cmndArg[3]);

                if (cmndArg[0] == "Add")
                {
                    

                    if(row >= 0 && col >= 0 && row<rows && col < jMatrix[row].Length)
                    {
                        jMatrix[row][col] += value;
                    }
                    else
                    {

                    }
                }
                else if (cmndArg[0] == "Subtract")
                {
                    if (row >= 0 && col >= 0 && row < rows && col < jMatrix[row].Length)
                    {
                        jMatrix[row][col] -= value;
                    }
                    else
                    {

                    }
                }
            }

            foreach(int [] row in jMatrix)
            {
                Console.WriteLine(string.Join(' ', row));
            }

        }

        private static void AnalizingJMatrix(int[][] jMatrix, int rows)
        {
            for(int r = 0; r < rows-1; r++)
            {
                if(jMatrix[r].Length == jMatrix[r+1].Length )
                {
                    jMatrix[r] = jMatrix[r].Select(el => el * 2).ToArray();
                    jMatrix[r + 1] = jMatrix[r + 1].Select(el => el * 2).ToArray();
                }
                else
                {
                    jMatrix[r] = jMatrix[r].Select(el => el / 2).ToArray();
                    jMatrix[r + 1] = jMatrix[r + 1].Select(el => el / 2).ToArray();

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
