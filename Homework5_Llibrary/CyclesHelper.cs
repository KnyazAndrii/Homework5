using System;

namespace Homework5_Library
{
    public class CyclesHelper
    {
        public static int RaiseToThePower(int a, int b)
        {
            if (b < 0)
            {
                throw new ArgumentException("B must be greater than zero");
            }

            int result = 1;

            for (int i = 0; i < b; i++)
            {
                result *= a;
            }

            return result;
        }

        public static int[] DivideBy(int a)
        {
            int num = GetNumInArr(a);
            int[] result = new int[num];
            int i = 0;

            for (int n = 1; n <= 1000; n++)
            {
                if (n % a == 0)
                {
                    result[i] = n;
                    i++;
                }
            }

            return result;
        }

        public static int GetNumInArr(int a)

        {
            if (a == 0)
            {
                throw new DivideByZeroException();
            }

            int num = 0;

            for (int n = 1; n <= 1000; n++)
            {
                if (n % a == 0)
                {
                    num++;
                }
            }

            return num;
        }

        public static int GetLessThanSquare(int a)
        {
            if (a <= 1)
            {
                throw new ArgumentException("Please, enter number A more than 1");
            }

            int number = 0;

            for (int i = 1; i * i < a; i++)
            {
                number++;
            }

            return number;
        }

        public static int GetLargestDivisor(int a)
        {
            if(a <= 1)
            {
                throw new ArgumentException("Please, enter number A more than 1");
            }

            int largestResult = 0;       

            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    largestResult = i;
                }
            }

            return largestResult;
        }

        public static int CalculateSum(int a, int b)
        {
            int sum = 0;

            if (b > a)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }

                return sum;
            }

            throw new ArgumentException("B must be more, than A");
        }

        public static int GetFibonacciNum(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("N must be greater than zero");
            }

            int firstNumber = 1;
            int secondNumber = 1;

            for (int i = 1; i < n; i++)
            {
                int temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp + secondNumber;
            }

            return firstNumber;
        }

        public static int UseEuclidAlgorithm(int firstNum, int secondNum)
        {
            if(firstNum <= 0 || secondNum <= 0)
            {
                throw new ArgumentException("Enter more, then zero value"); 
            }

            while (firstNum != 0 && secondNum != 0)
            {
                if (firstNum > secondNum)
                {
                    firstNum %= secondNum;
                }
                else
                {
                    secondNum %= firstNum;
                }
            }

            return firstNum + secondNum;
        }

        public static int FindCubeBinary(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number must be greater than zero");
            }

            int n = 0;

            for (int i = 0; i <= number; i++)
            {
                if (i * i * i <= number)
                {
                    n = i;
                }
            }

            return n;
        }

        public static int FindDigits(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number must be greater than zero");
            }

            int digit = 0;
            int n = 0;

            while (number >= 1)
            {
                digit = number % 10;
                number = number / 10;

                if (digit % 2 != 0)
                {
                    n++;
                }
            }

            return n;
        }

        public static int MirrorNumber(int number)
        {
            int result = 0;

            while (number != 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }

            return result;
        }

        public static int CalulateNumInArr(int n)
        {
            if (n < 1)
            {
                throw new ArgumentException("N must be greater than one");
            }

            int num = 0;

            for (int i = 1; i <= n; i++)
            {
                int sumEven = 0;
                int sumOdd = 0;
                int j = i;

                while (j >= 1)
                {
                    int digit = 0;
                    digit = j % 10;
                    j = j / 10;

                    if (digit % 2 == 0)
                    {
                        sumEven += digit;
                    }
                    else
                    {
                        sumOdd += digit;
                    }
                }

                if (sumEven > sumOdd)
                {
                    num++;
                }
            }

            return num;
        }

        public static int[] SumGreaterDigits(int n)
        {
            int[] arr = new int[CalulateNumInArr(n)];
            int num = 0;

            for (int i = 1; i <= n; i++)
            {
                int sumEven = 0;
                int sumOdd = 0;
                int j = i;

                while (j >= 1)
                {
                    int digit = 0;
                    digit = j % 10;
                    j = j / 10;

                    if (digit % 2 == 0)
                    {
                        sumEven += digit;
                    }
                    else
                    {
                        sumOdd += digit;
                    }
                }

                if (sumEven > sumOdd)
                {
                    arr[num] = i;
                    num++;
                }
            }

            return arr;
        }

        public static bool CompareDigits(int firstNum, int secondNum)
        {
            int firstDigit = 0;
            int secondDigit = 0;
            bool result = true;

            while (firstNum >= 1)
            {
                firstDigit = firstNum % 10;
                firstNum = firstNum / 10;

                while (secondNum >= 1)
                {
                    secondDigit = secondNum % 10;
                    secondNum = secondNum / 10;

                    if (firstDigit == secondDigit)
                    {
                        return result;
                    }
                }
            }

            result = false;

            return result;
        }

    }
}
