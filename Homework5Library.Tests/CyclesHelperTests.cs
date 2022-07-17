using Homework5_Library;
using NUnit.Framework;
using System;

namespace Homework5Library.Tests
{
    class CyclesHelperTests
    {
        [TestCase(23, 0, 1)]
        [TestCase(3, 3, 27)]
        public void RaiseToThePower_WhenBIsPositive_ShouldPower
            (int a, int b, int expected)
        {
            int actual = CyclesHelper.RaiseToThePower(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, -5)]
        [TestCase(-7, -1)]
        public void RaiseToThePower_WhenBIsNegative_ShouldThrowExeption
            (int a, int b)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CyclesHelper.RaiseToThePower(a, b);
            });
        }

        [TestCase(100, new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 })]
        [TestCase(-100, new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 })]
        public void DivideBy_WhenANotZero_ShouldReturnArray
            (int a, int[] expected)
        {
            int[] actual = CyclesHelper.DivideBy(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void DivideBy_WhenAIsZero_ShouldThrowExeption
            (int a)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                CyclesHelper.DivideBy(a);
            });
        }

        [TestCase(15, 3)]
        [TestCase(25, 4)]
        public void GetLessThanSquare_WhenAMoreThanOne_ShouldReturnNumber
            (int a, int expected)
        {
            int actual = CyclesHelper.GetLessThanSquare(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        [TestCase(0)]
        [TestCase(-5)]
        public void GetLessThanSquare_WhenALessThanOne_ShouldThrowExeption
            (int a)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CyclesHelper.GetLessThanSquare(a);
            });
        }

        [TestCase(100, 50)]
        [TestCase(2, 1)]
        public void GetLargestDivisor_WhenAIsMoreThanOne_ShouldReturnLargestDivisor
            (int a, int expected)
        {
            int actual = CyclesHelper.GetLargestDivisor(a);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        [TestCase(0)]
        [TestCase(-99)]
        public void GetLargestDivisor_WhenAIsLessThanOne_ShouldThrowExeption
            (int a)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CyclesHelper.GetLessThanSquare(a);
            });
        }

        [TestCase(-12, 0, -7)]
        [TestCase(-21, -7, -42)]
        [TestCase(-15, 8, -14)]
        [TestCase(1, 30, 70)]
        public void CalculateSum_WhenAIsLessThanB_ShouldReturnSum
            (int a, int b, int expected)
        {
            int actual = CyclesHelper.CalculateSum(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 0)]
        [TestCase(0, -99)]
        [TestCase(-7, -21)]
        public void CalculateSum_WhenAIsMoreThanB_ShouldThrowExeption
            (int a, int b)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CyclesHelper.CalculateSum(a, b);
            });
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(5, 5)]
        public void GetFibonacciNum_WhenNIsBiggerThanZero_ShouldReturnNumber
            (int n, int expected)
        {
            int actual = CyclesHelper.GetFibonacciNum(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-8)]
        public void GetFibonacciNum_WhenNIsLowerThanZero_ShouldThrowExeption
            (int n)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CyclesHelper.GetFibonacciNum(n);
            });
        }

        [TestCase(106, 16, 2)]
        [TestCase(1, 20, 1)]
        public void UseEuclidAlgorithm_WhenNumsAreMoreThanNull_ShouldFindDivisor
            (int firstNum, int secondNum, int expected)
        {
            int actual = CyclesHelper.UseEuclidAlgorithm(firstNum, secondNum);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 4)]
        [TestCase(-8, -3)]
        [TestCase(5, 0)]
        [TestCase(-1, -9)]
        public void UseEuclidAlgorithm_WhenNumsAreLessThanNull_ShouldThrowExeption
            (int firstNum, int secondNum)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CyclesHelper.UseEuclidAlgorithm(firstNum, secondNum);
            });
        }

        [TestCase(125, 5)]
        [TestCase(1, 1)]
        [TestCase(0, 0)]
        public void FindCubeBinary_WhenNumberIsMoreThanNull_ShouldFindDivisor
            (int number, int expected)
        {
            int actual = CyclesHelper.FindCubeBinary(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-9)]
        public void FindCubeBinary_WhenNumberIsLessThanNull_ShouldFindDivisor
            (int number)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CyclesHelper.FindCubeBinary(number);
            });
        }

        [TestCase(123456789, 5)]
        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(12, 1)]
        [TestCase(1234, 2)]
        public void FindDigits_WhenNumberIsMoreThanNull_ShouldFindNumberOddDigits
            (int number, int expected)
        {
            int actual = CyclesHelper.FindDigits(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-34)]
        public void FindDigits_WhenNumberIsLessThanNull_ShouldThrowExeption
            (int number)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CyclesHelper.FindDigits(number);
            });
        }

        [TestCase(5, 5)]
        [TestCase(-987, -789)]
        [TestCase(386426, 624683)]
        public void MirrorNumber_WhenNumberIsCommon_ShouldMirror
            (int number, int expected)
        {
            int actual = CyclesHelper.MirrorNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, new int[] { 2, 4 })]
        [TestCase(20, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20 })]
        public void SumGreaterDigits_WhenNIsMoreThanOne_ShouldReturnSum
            (int n, int[] expected)
        {
            int[] actual = CyclesHelper.SumGreaterDigits(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-30)]
        public void SumGreaterDigits_WhenNIsLessThanOne_ShouldThrowExeption
            (int number)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                CyclesHelper.SumGreaterDigits(number);
            });
        }

        [TestCase(1, 1365187, true)]
        [TestCase(24353, 3589, true)]
        [TestCase(27183, 04, false)]
        [TestCase(12345, 67890, false)]
        public void CompareDigits_WhenNnumsAreCommon_ShouldCompareNumbers
            (int firstNum, int secondNum, bool expected)
        {
            bool actual = CyclesHelper.CompareDigits(firstNum, secondNum);

            Assert.AreEqual(expected, actual);
        }
    }
}
