using System;

namespace Homework5_Library
{
    public class MultiDimensionalArrayHelper
    {
        public static int[,] CreateMatrix(int rows, int columns)
        {
            if(rows <= 0 || columns <= 0)
            {
                throw new ArgumentException("Rows and colums must be more, than zero!");
            }

            Random random = new Random();
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(10, 99);
                }
            }

            return matrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        public static (int minI, int minJ) FindMinIndex(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Empty or null matrix!");
            }

            int minI = 0;
            int minJ = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < matrix[minI, minJ])
                    {
                        minI = i;
                        minJ = j;
                    }
                }
            }

            return (minI, minJ);
        }

        public static (int minI, int minJ) FindMaxIndex(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                throw new ArgumentException("Empty or null matrix!");
            }

            int minI = 0;
            int minJ = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > matrix[minI, minJ])
                    {
                        minI = i;
                        minJ = j;
                    }
                }
            }

            return (minI, minJ);
        }

        public static int FindMinElement(int[,] matrix)
        {
            (int minI, int minJ) = FindMinIndex(matrix);

            return matrix[minI, minJ];
        }

        public static int FindMaxElement(int[,] matrix)
        {
            (int minI, int minJ) = FindMaxIndex(matrix);

            return matrix[minI, minJ];
        }

        public static int CalcGreaterThanNeighbors(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentException("Null matrix!");
            }

            int num = 0;
            bool checker = true;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int insideI = (i - 1); insideI <= (i + 1); insideI++)
                    {
                        for (int insideJ = (j - 1); insideJ <= (j + 1); insideJ++)
                        {
                            if(insideI < 0 || insideI == matrix.GetLength(0) || 
                               insideJ < 0 || insideJ == matrix.GetLength(1))
                            {
                                checker = true;
                            }
                            else if(i == insideI && j == insideJ)
                            {
                                checker = true;
                            }
                            else if(matrix[i, j] > matrix[insideI, insideJ])
                            {
                                checker = true;
                            }
                            else
                            {
                                checker = false;
                                break;
                            }
                        }

                        if (checker == false)
                        {
                            break;
                        }
                    }

                    if (checker == true)
                    {
                        num++;
                    }
                }
            }

            return num;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int[,] FlipMatrix(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentException("Null matrix!");
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i; j < matrix.GetLength(1); j++)
                {
                    Swap(ref matrix[i, j], ref matrix[j, i]);
                }
            }

            return matrix;
        }
    }
}
