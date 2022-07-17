using System;

namespace Homework5_Library
{
    public class ConditionalStructuresHelper
    {
        public static int ValidateTwoNumbers(int a, int b)
        {
            int result = 0;

            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }

            return result;
        }

        public static int DetermineQuarter(int x, int y)
        {
            if(x == 0 || y == 0)
            {
                throw new ArgumentException("X and Y must be more than 0");
            }

            int quarter = 0;

            if (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    quarter = 1;
                }
                else if (x < 0 && y > 0)
                {
                    quarter = 2;
                }
                else if (x < 0 && y < 0)
                {
                    quarter = 3;
                }
                else
                {
                    quarter = 4;
                }
            }

            return quarter;
        }

        public static (int a, int b, int c) SelectFromLowToHigh(int a, int b, int c)
        {
            if(a == b || b == c || a == c)
            {
                throw new ArgumentException("Numbers must be different");
            }

            if (a > b)
            {
                Swap(ref a, ref b);
            }
            if (a > c)
            {
                Swap(ref a, ref c);
            }
            if (b > c)
            {
                Swap(ref b, ref c);
            }

            return (a, b, c);
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static (double x1, double x2) CalculateQuadraticEquation(double a, double b, double c)
        {
            double x1 = 0;
            double x2 = 0;
            double SqrtD = Math.Sqrt(b * b - 4 * a * c);

            if (SqrtD > 0)
            {
                x1 = (-b + SqrtD) / (2 * a);
                x2 = (-b - SqrtD) / (2 * a);

            }
            else if (SqrtD == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
            }
            else
            {
                throw new ArgumentException("Sqrt must be more, than zero");
            }

            return (x1, x2);
        }

        public static string CapitalizateNumbers(int num)
        {
            if (num >= 100 || num < 10)
            {
                throw new ArgumentException("Number must be from 10 to 99");
            }

            string firstWord = string.Empty;
            string secondWord = string.Empty;

            int firstDigit = num / 10;
            int secondDigit = num % 10;

            if (firstDigit != 1)
            {
                firstWord = GetDozens(firstDigit);
                secondWord = GetUnits(secondDigit);

                return $"{firstWord} {secondWord}";
            }
            else
            {
                firstWord = GetFormTenToNineteen(secondDigit);

                return firstWord;
            }
        }

        public static string GetDozens(int firstDigit)
        {
            string result = string.Empty;

            switch (firstDigit)
            {
                case 2:
                    result = "twenty";
                    break;
                case 3:
                    result = "thirty";
                    break;
                case 4:
                    result = "forty";
                    break;
                case 5:
                    result = "fifty";
                    break;
                case 6:
                    result = "sixty";
                    break;
                case 7:
                    result = "seventy";
                    break;
                case 8:
                    result = "eighty";
                    break;
                case 9:
                    result = "ninety";
                    break;
            }

            return result;
        }

        public static string GetUnits(int secondDigit)
        {
            string result = string.Empty;

            switch (secondDigit)
            {
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "three";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
            }

            return result;
        }

        public static string GetFormTenToNineteen(int secondDigit)
        {
            string result = string.Empty;

            switch (secondDigit)
            {
                case 0:
                    result = "ten";
                    break;
                case 1:
                    result = "eleven";
                    break;
                case 2:
                    result = "twelve";
                    break;
                case 3:
                    result = "thirteen";
                    break;
                case 4:
                    result = "fourteen";
                    break;
                case 5:
                    result = "fifteen";
                    break;
                case 6:
                    result = "sixteen";
                    break;
                case 7:
                    result = "seventeen";
                    break;
                case 8:
                    result = "eighteen";
                    break;
                case 9:
                    result = "nineteen";
                    break;
            }

            return result;
        }
    }
}