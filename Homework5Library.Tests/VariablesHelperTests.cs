using Homework5_Library;
using NUnit.Framework;
using System;

namespace Homework5Library.Tests
{
    public class VariablesHelperTests
    {
        [TestCase(10, 600)]
        [TestCase(0, 0)]
        public void ConvertHoursToMinutes_WhenNumHoursIsPositive_ShouldFindNumMinutes
            (int numHours, int expected)
        {
            int actual = VariablesHelper.ConvertHoursToMinutes(numHours);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-20)]
        public void ConvertHoursToMinutes_WhenNumHoursIsNegative_ShouldThrowExeption 
            (int numHours)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                VariablesHelper.ConvertHoursToMinutes(numHours);
            });
        }

        [TestCase(5, 6, 61)]
        [TestCase(6, 5, -55)]
        [TestCase(-2, 2, -1.5)]
        [TestCase(8, -5, -5)]
        public void CalculateEquation_WhenAAndBAreNotEqual_ShouldCalculateEquation
            (int a, int b, double expected)
        {
            double actual = VariablesHelper.CalculateEquation(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(4, 4)]
        [TestCase(-9.5, -9.5)]
        public void CalculateEquation_WhenAAndBAreEqual_ShouldThrowExeption
            (double a, double b)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                VariablesHelper.CalculateEquation(a, b);
            });
        }

        [TestCase(9, 10, 0)]
        [TestCase(12, 3, 4)]
        [TestCase(-5, 2, -2)]
        [TestCase(-20, -10, 2)]
        public void Divide_WhenBIsNotZero_ShouldDivide
            (int a, int b, int expected)
        {
            int actual = VariablesHelper.Divide(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(4, 0)]
        [TestCase(-9, 0)]
        public void Divide_WhenBIsZero_ShouldThrowExeption
            (int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                VariablesHelper.Divide(a, b);
            });
        }

        [TestCase(2, 5, 2)]
        [TestCase(12, 10, 2)]
        [TestCase(-5, 7, -5)]
        [TestCase(-13, -7, -6)]
        public void DivideRemind_WhenBNotZero_ShouldDivideWithRemind
            (int a, int b, int expected)
        {
            int actual = VariablesHelper.DivideRemind(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(6, 0)]
        [TestCase(-1, 0)]
        public void DivideRemind_WhenBIsZero_ShouldThrowExeption
            (int a, int b)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                VariablesHelper.DivideRemind(a, b);
            });
        }

        [TestCase(9, 1, 6.5, 0.61)]
        [TestCase(-5, 0, 5, -1)]
        [TestCase(-9, -4.25, 0, -0.47)]
        public void CalculateLinearEquation_WhenAIsNotZero_ShouldReturnResult
            (double a, double b, double c, double expected)
        {
            double actual = VariablesHelper.CalculateLinearEquation(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 2, 7.56)]
        [TestCase(0, 9.526, 1.31)]
        public void CalculateLinearEquation_WhenAIsNotZero_ShouldThrowExeption
            (double a, double b, double c)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                VariablesHelper.CalculateLinearEquation(a, b, c);
            });
        }

        [TestCase(1.25, 2, 5, 6.25, 1.13)]
        [TestCase(8, -9.5, 0, -5.5, -0.5)]
        [TestCase(0, 0, -9, 0, 0)]
        public void MakeStraightLineEquation_WhenXAreNotEqual_ShouldCalculateEquation
            (double x1, double y1, double x2, double y2, double expected)
        {
            double actual = VariablesHelper.MakeStraightLineEquation(x1, y1, x2, y2);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 2.25, 0, 0)]
        [TestCase(-2, 9.5, -2, 10.5)]
        public void MakeStraightLineEquation_WhenXAreNotEqual_ShouldCalculateEquation
            (double x1, double y1, double x2, double y2)
        {
            Assert.Throws<DivideByZeroException>(() =>
            {
                VariablesHelper.MakeStraightLineEquation(x1, y1, x2, y2);
            });
        }

        [TestCase(0, 0)]
        [TestCase(8, 8)]
        [TestCase(28, 10)]
        [TestCase(-6, -6)]
        [TestCase(-25, -7)]
        public void CalculateSumOfDigits_WhenNIsCommon_ShouldCalculateDigits
            (int n, int expected)
        {
            int actual = VariablesHelper.CalculateSumOfDigits(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(105)]
        [TestCase(-532)]
        public void CalculateSumOfDigits_WhenNIsTooBig_ShouldThrowExeption
            (int n)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                VariablesHelper.CalculateSumOfDigits(n);
            });
        }
    }
}