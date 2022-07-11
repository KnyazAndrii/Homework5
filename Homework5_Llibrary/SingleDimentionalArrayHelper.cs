using System;

namespace Homework5_Library
{
    public class SingleDimentionalArrayHelper
    {
        public static int[] CreateArray(int size)
        {
            if(size <= 0)
            {
                throw new ArgumentException("Please, enter more, than zero value for size");
            }

            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, 100);
            }

            return array;
        }

        public static int FindMinIndex(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Empty or null array!");
            }

            int minI = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[minI])
                {
                    minI = i;
                }
            }

            return minI;
        }

        public static int FindMaxIndex(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Empty or null array!");
            }

            int maxI = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxI])
                {
                    maxI = i;
                }
            }

            return maxI;
        }

        public static int FindMinElement(int[] arr)
        {
            int minI = FindMinIndex(arr);

            return arr[minI];
        }

        public static int FindMaxElement(int[] arr)
        {
            int maxI = FindMaxIndex(arr);

            return arr[maxI];
        }

        public static int CalcSumOddElements(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentException("Null array!");
            }

            int sum = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static int[] ReverseArray(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentException("Null array!");
            }

            int lastIndex = arr.Length - 1;

            for (int i = 0; i < (arr.Length / 2); i++)
            {
                Swap(ref arr[i], ref arr[lastIndex--]);
            }

            return arr;
        }

        public static int CountOddElements(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentException("Null array!");
            }

            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    count += arr[i];
                }
            }

            return count;
        }

        public static int[] SwapHalfs(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentException("Null array!");
            }

            int middle = arr.Length / 2;
            int startLastHalf = arr.Length - middle;

            for (int i = 0; i < middle; i++)
            {
                Swap(ref arr[i], ref arr[startLastHalf]);
                startLastHalf++;
            }

            return arr;
        }

        public static int[] SortSelection(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentException("Null array!");
            }

            for (int j = 0; j < arr.Length - 1; j++)
            {
                int smallestVal = j;
                for (int i = j + 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[smallestVal])
                    {
                        smallestVal = i;
                    }
                }
                int temp = arr[smallestVal];
                arr[smallestVal] = arr[j];
                arr[j] = temp;
            }

            return arr;
        }

        public static int[] SortDescend(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentException("Null array!");
            }

            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        Swap(ref arr[i], ref arr[i + 1]);
                    }
                }
            }

            return arr;
        }
    }
}

