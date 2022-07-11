using Homework5_Library;
using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = { { 41, 28 }, { -22, 34 } };
            int[,] matrix2 = { { -20, -33 }, { 11, 46 }, { 18, 13 } };
            int[,] matrix3 = { { -20, -33, 21 }, { 11, 46, 48 }, { 18, 13, 45 },
                    { -33, 16, -12 }, { -10, -2, -43 }, {44, -43, 36 } };
            MultiDimensionalArrayHelper.FlipMatrix(matrix1);
            MultiDimensionalArrayHelper.PrintMatrix(matrix1);
            Console.WriteLine();
            MultiDimensionalArrayHelper.FlipMatrix(matrix2);
            MultiDimensionalArrayHelper.PrintMatrix(matrix2);
            Console.WriteLine();
            MultiDimensionalArrayHelper.FlipMatrix(matrix3);
            MultiDimensionalArrayHelper.PrintMatrix(matrix3);
        }
    }
}
