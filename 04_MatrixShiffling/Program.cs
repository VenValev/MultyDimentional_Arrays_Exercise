using System;

namespace _04_MatrixShiffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] demetions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(demetions[0]);
            int cols = int.Parse(demetions[1]);
            string[,] matrix = new string[rows, cols];

            FillingTheMatrix(matrix, rows, cols);

            string cmnd;

            while((cmnd = Console.ReadLine()) != "END")
            {
                string[] cmndArg = cmnd.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if(CommandValidation(matrix,rows,cols,cmndArg))
                {
                    string firstItem = matrix[cmnd[1], cmnd[2]];
                    string secondItem = matrix[cmnd[3], cmnd[4]];
                    matrix[cmnd[1], cmnd[2]] = secondItem;
                    matrix[cmnd[3], cmnd[4]] = firstItem;

                    PrintMatrix(matrix, rows, cols);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        private static void PrintMatrix(string[,] matrix, int rows, int cols)
        {
            for(int r = 0; r < rows; r ++)
            {
                for(int c = 0; c < cols; c ++)
                {
                    Console.Write($"{matrix[r, c]} ");
                }
                Console.WriteLine();
            }
        }

        private static bool CommandValidation(string[,] matrix, int rows, int cols, string[] cmndArg)
        {
            if (cmndArg[0] != "swap" && cmndArg.Length<5)
            {
                return false;
            }
            else
            {
                int firstNumberRow = int.Parse(cmndArg[1]);
                int firstNumberCol = int.Parse(cmndArg[2]);
                int secondNumberRow = int.Parse(cmndArg[3]);
                int secindNumberCol = int.Parse(cmndArg[4]);

                if (CoordinatesBiggerThanZero(firstNumberRow,
                    firstNumberCol,
                    secondNumberRow,
                    secindNumberCol)
                    &&
                    ValidCoordinates(firstNumberRow,
                    firstNumberCol,
                    secondNumberRow,
                    secindNumberCol, rows, cols))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private static bool ValidCoordinates(int firstNumberRow, int firstNumberCol, int secondNumberRow, int secindNumberCol, int rows, int cols)
        {
            if(firstNumberRow >= rows || 
                firstNumberCol >= cols || 
                secondNumberRow >= rows || 
                secindNumberCol >=cols)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static bool CoordinatesBiggerThanZero(int firstNumberRow,
            int firstNumberCol,
            int secondNumberRow,
            int secindNumberCol)
        {
            if(firstNumberRow >= 0 && firstNumberCol >= 0 && secondNumberRow >= 0 && secindNumberCol >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void FillingTheMatrix(string[,] matrix, int rows, int cols)
        {
            for(int r = 0; r < rows; r++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for(int c = 0; c < cols; c++)
                {
                    matrix[r, c] = line[c];
                }
            }
        }
    }
}
