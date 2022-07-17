using Homework5_Library;
using NUnit.Framework;
using System;

namespace Homework5Library.Tests
{
    class ConditionalStructuresHelperTests
    {
        [TestCase(10, 6, 16)]
        [TestCase(0, 0, 0)]
        [TestCase(-2, 5, -7)]
        public void ValidateTwoNumbers_WhenAAndBAreRandom_ShouldDoCalculation
            (int a, int b, int expected)
        {
            int actual = ConditionalStructuresHelper.ValidateTwoNumbers(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(4, 9, 1)]
        [TestCase(-2, 5, 2)]
        [TestCase(-3, -1, 3)]
        [TestCase(1, -6, 4)]
        public void DetermineQuarter_WhenXAndYAreNotZero_ShouldFindQuarter
            (int x, int y, int expected)
        {
            int actual = ConditionalStructuresHelper.DetermineQuarter(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 7)]
        [TestCase(-4, 0)]
        [TestCase(0, 0)]
        public void DetermineQuarter_WhenXAndYAreZero_ShouldThrowExeption
            (int x, int y)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ConditionalStructuresHelper.DetermineQuarter(x, y);
            });
        }

        [TestCase(-3, 4, -8, -8, -3, 4)]
        [TestCase(-9, 1, 0, -9, 0, 1)]
        [TestCase(-9, -5, -1, -9, -5, -1)]
        public void SelectFromLowToHigh_WhenAAndBAndCAreNotEqual_ShouldSort
            (int a, int b, int c, int expectedA, int expectedB, int expectedC)
        {
            (a, b, c) = ConditionalStructuresHelper.SelectFromLowToHigh(a, b, c);

            Assert.AreEqual((expectedA, expectedB, expectedC), (a, b, c));
        }

        [TestCase(0, 0, 2)]
        [TestCase(-4, 5, 5)]
        [TestCase(9, 3, 9)]
        [TestCase(-1, -1, -1)]
        public void SelectFromLowToHigh_WhenAAndBAndCAreEqual_ShouldThrowExeption
            (int a, int b, int c)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ConditionalStructuresHelper.SelectFromLowToHigh(a, b, c);
            });
        }

        [TestCase(1, -3, 2, 2, 1)]
        [TestCase(1, -10, 25, 5, 5)]
        public void CalculateQuadraticEquation_WhenDIsPositive_ShouldCalculateEquation
            (double a, double b, double c, double expectedX1, double expectedX2)
        {
            (double x1, double x2) = ConditionalStructuresHelper.CalculateQuadraticEquation(a, b, c);

            Assert.AreEqual((expectedX1, expectedX2), (x1, x2));
        }

        [TestCase(3, -3, 3)]
        [TestCase(9, -5, 1)]
        public void CalculateQuadraticEquation_WhenDIsNegative_ShouldThrowExeption
            (int a, int b, int c)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ConditionalStructuresHelper.CalculateQuadraticEquation(a, b, c);
            });
        }

        [TestCase(10, "ten")]
        [TestCase(11, "eleven")]
        [TestCase(12, "twelve")]
        [TestCase(13, "thirteen")]
        [TestCase(14, "fourteen")]
        [TestCase(15, "fifteen")]
        [TestCase(16, "sixteen")]
        [TestCase(17, "seventeen")]
        [TestCase(18, "eighteen")]
        [TestCase(19, "nineteen")]
        [TestCase(20, "twenty ")]
        [TestCase(31, "thirty one")]
        [TestCase(42, "forty two")]
        [TestCase(53, "fifty three")]
        [TestCase(64, "sixty four")]
        [TestCase(75, "seventy five")]
        [TestCase(86, "eighty six")]
        [TestCase(97, "ninety seven")]
        [TestCase(28, "twenty eight")]
        [TestCase(39, "thirty nine")]
        public void CapitalizateNumbers_WhenNumIsCommon_ShouldWriteWord
            (int num, string expected)
        {
            string actual = ConditionalStructuresHelper.CapitalizateNumbers(num);

            Assert.AreEqual(expected, actual);
        }
    }
}
