using System;

namespace Homework5_Library
{
    public class VariablesHelper
    {
        public static int ConvertHoursToMinutes(int numHours)
        {
            if (numHours < 0)
            {
                throw new ArgumentException("Please, enter a non-zero value!");
            }

            return numHours * 60;
        }

        public static double CalculateEquation(double a, double b)
        {
            if(b == a)
            {
                throw new DivideByZeroException("b - a = 0");    
            }

            return (5 * a + b * b) / (b - a);
        }

        private static void Swap(ref string a, ref string b)
        {
            string swap = a;
            a = b;
            b = swap;
        }

        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            return a / b;
        }

        public static int DivideRemind(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            return a % b;
        }

        public static double CalculateLinearEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new DivideByZeroException();
            }

            return Math.Round(((c - b) / a), 2);
        }

        public static double MakeStraightLineEquation
            (double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                throw new DivideByZeroException();
            }

            return Math.Round(((y2 - y1) / (x2 - x1)), 2);
        }

        public static int CalculateSumOfDigits(int n)
        {
            int FirstDigit = n / 10;
            int SeccondDigit = n % 10;

            if(FirstDigit >= 10 || FirstDigit <= -10)
            {
                throw new ArgumentException("N must be from -99 to 99");
            }

            return FirstDigit + SeccondDigit;
        }
    }
}