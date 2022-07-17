using Homework5_Library;
using NUnit.Framework;
using System;

namespace Homework5Library.Tests
{
    class MultiDimensionalArrayHelperTests
    {
        [TestCase(0, 4)]
        [TestCase(5, 0)]
        [TestCase(-3, -7)]
        [TestCase(2, -1)]
        public void CreateMatrix_WhereSizeLessThanZero_ShouldThrowException
           (int rows, int columns)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MultiDimensionalArrayHelper.CreateMatrix(rows, columns);
            });
        }

        [TestCaseSource(nameof(DataForMinIndex))]
        public void FindMinIndex_WhenArrNotNullAndZero_ShouldReturnMinIndex
            (int[,] matrix, int expectedMinI, int expectedMinJ)
        {
            (int minI, int minJ) = MultiDimensionalArrayHelper.FindMinIndex(matrix);

            Assert.AreEqual((expectedMinI, expectedMinJ), (minI, minJ));
        }

        private static object[] DataForMinIndex =
        {
            new object[]
            {
                new[,] { {41, 28 }, {-22, 34 } }, 1, 0
            },
            new object[]
            {
                new[,] { { -20, -33 }, { 11, 46 }, { 18, 13 } }, 0, 1
            }
        };

        [TestCase(null)]
        [TestCaseSource(nameof(DataForZero))]
        public void FindMinIndex_WhenArrIsNullOrZero_ShouldThrowException
            (int[,] matrix)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MultiDimensionalArrayHelper.FindMinIndex(matrix);
            });
        }

        private static object[] DataForZero =
        {
            new object[]
            {
                new int[,] { } 
            },
        };

        [TestCaseSource(nameof(DataForMaxIndex))]
        public void FindMaxIndex_WhenArrNotNullAndZero_ShouldReturnMaxIndex
            (int[,] matrix, int expectedMaxI, int expectedMaxJ)
        {
            (int maxI, int maxJ) = MultiDimensionalArrayHelper.FindMaxIndex(matrix);

            Assert.AreEqual((expectedMaxI, expectedMaxJ), (maxI, maxJ));
        }

        private static object[] DataForMaxIndex =
        {
            new object[]
            {
                new[,] { {41, 28 }, {-22, 34 } }, 0, 0
            },
            new object[]
            {
                new[,] { { -20, -33 }, { 11, 46 }, { 18, 13 } }, 1, 1
            }
        };

        [TestCase(null)]
        [TestCaseSource(nameof(DataForZero))]
        public void FindMaxIndex_WhenArrIsNullOrZero_ShouldThrowException
            (int[,] matrix)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MultiDimensionalArrayHelper.FindMaxIndex(matrix);
            });
        }

        [TestCaseSource(nameof(DataForMinElement))]
        public void FindMinElement_WhenArrNotNullAndZero_ShouldReturnMinElement
            (int[,] matrix, int expected)
        {
            int actual = MultiDimensionalArrayHelper.FindMinElement(matrix);

            Assert.AreEqual(expected, actual);
        }

        private static object[] DataForMinElement =
        {
            new object[]
            {
                new[,] { {41, 28 }, {-22, 34 } }, -22
            },
            new object[]
            {
                new[,] { { -20, -33 }, { 11, 46 }, { 18, 13 } }, -33
            }
        };

        [TestCaseSource(nameof(DataForMaxElement))]
        public void FindMaxElement_WhenArrNotNullAndZero_ShouldReturnMaxElement
            (int[,] matrix, int expected)
        {
            int actual = MultiDimensionalArrayHelper.FindMaxElement(matrix);

            Assert.AreEqual(expected, actual);
        }

        private static object[] DataForMaxElement =
        {
            new object[]
            {
                new[,] { {41, 28 }, {-22, 34 } }, 41
            },
            new object[]
            {
                new[,] { { -20, -33 }, { 11, 46 }, { 18, 13 } }, 46
            }
        };

        [TestCaseSource(nameof(DataForCalcGreaterThanNeighbors))]
        public void CalcGreaterThanNeighbors_WhenArrNotNull_ShouldReturnNumberElements
            (int[,] matrix, int expected)
        {
            int actual = MultiDimensionalArrayHelper.CalcGreaterThanNeighbors(matrix);

            Assert.AreEqual(expected, actual);
        }

        private static object[] DataForCalcGreaterThanNeighbors =
        {
            new object[]
            {
                new[,] { {41, 28 }, {-22, 34 } }, 1
            },
            new object[]
            {
                new[,] { { -20, -33 }, { 11, 46 }, { 18, 13 } }, 1
            },
            new object[]
            {
                new[,] { { -20, -33, 21 }, { 11, 46, 48 }, { 18, 13, 45 }, 
                    { -33, 16, -12 }, { -10, -2, -43 }, {44, -43, 36 } }, 3
            }
        };

        [TestCase(null)]
        public void CalcGreaterThanNeighbors_WhenArrNotNull_ShouldThrowException
            (int[,] matrix)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MultiDimensionalArrayHelper.CalcGreaterThanNeighbors(matrix);
            });
        }

        [TestCaseSource(nameof(DataForFlipMatrix))]
        public void FlipMatrix_WhenArrNotNull_ShouldReturnReversedMatrix
            (int[,] matrix, int[,] expected)
        {
            int[,] actual = MultiDimensionalArrayHelper.FlipMatrix(matrix);

            Assert.AreEqual(expected, actual);
        }

        private static object[] DataForFlipMatrix =
        {
            new object[]
            {
                new[,] { {41, 28 }, {-22, 34 } },
                new[,] { { 41, -22 }, { 28, 34 } }
            },
            new object[]
            {
                new[,] { { -20, -33 }, { 11, 46 }, { 18, 13 } },
                new[,] { { -20, 11 }, { -33, 46 }, { 18, 13 } }
            },
            new object[]
            {
                new[,] { { -20, -33, 21 }, { 11, 46, 48 }, { 18, 13, 45 },
                    { -33, 16, -12 }, { -10, -2, -43 }, { 44, -43, 36 } }, 
                new[,] { { -20, 11, 18 }, { -33, 46, 13 }, { 21, 48, 45 },
                    { -33, 16, -12 }, { -10, -2, -43 }, { 44, -43, 36 } }
            }
        };

        [TestCase(null)]
        public void FlipMatrix_WhenArrIsNull_ShouldThrowException
            (int[,] matrix)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                MultiDimensionalArrayHelper.FlipMatrix(matrix);
            });
        }
    }
}
