using Homework5_Library;
using NUnit.Framework;
using System;

namespace Homework5Library.Tests
{
    class SingleDimentionalArrayHelperTests
    {
        [TestCase(0)]
        [TestCase(-2)]
        public void CreateArray_WhereSizeLessThanZero_ShouldThrowException
            (int size)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                SingleDimentionalArrayHelper.CreateArray(size);
            });  
        }

        [TestCase(new int[] { -37, -18, -31, 17, 15, -16, -27, -25, 10, 21 }, 0)]
        [TestCase(new int[] { -27, -18, -31, 17, 15, -16, -37, -25, 10, 21 }, 6)]
        [TestCase(new int[] { 0, -18, -31, -31, 15, -16, -27, -25, 10, 21 }, 2)]
        [TestCase(new int[] { 1, 1, 1, 1 }, 0)]
        public void FindMinIndex_WhenArrNotEmptyAndNull_ShouldReturnIndex
            (int[] arr, int expected)
        {
            int actual = SingleDimentionalArrayHelper.FindMinIndex(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(null)]
        public void FindMinIndex_WhenArrIsEmptyAndNull_ShouldThrowException
            (int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                SingleDimentionalArrayHelper.FindMinIndex(arr);
            });
        }

        [TestCase(new int[] { -37, -18, -31, 17, 15, -16, -27, -25, 10, 21 }, 9)]
        [TestCase(new int[] { -27, -18, 31, 17, 15, -16, -37, -25, 10, 21 }, 2)]
        [TestCase(new int[] { 0, -18, -31, -31, 15, -16, -27, -25, 21, 21 }, 8)]
        [TestCase(new int[] { 1, 1, 1, 1 }, 0)]
        public void FindMaxIndex_WhenArrNotEmptyAndNull_ShouldReturnIndex
            (int[] arr, int expected)
        {
            int actual = SingleDimentionalArrayHelper.FindMaxIndex(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        [TestCase(null)]
        public void FindMaxIndex_WhenArrIsEmptyAndNull_ShouldThrowException
            (int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                SingleDimentionalArrayHelper.FindMaxIndex(arr);
            });
        }

        [TestCase(new int[] { -37, -18, -31, 17, 15, -16, -27, -25, 10, 21 }, -37)]
        [TestCase(new int[] { -27, -18, -31, 17, 15, -16, -37, -25, 10, 21 }, -37)]
        [TestCase(new int[] { 0, -18, -31, -31, 15, -16, -27, -25, 10, 21 }, -31)]
        [TestCase(new int[] { 1, 1, 1, 1 }, 1)]
        public void FindMinElement_WhenArrNotEmptyAndNull_ShouldReturnElement
            (int[] arr, int expected)
        {
            int actual = SingleDimentionalArrayHelper.FindMinElement(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { -37, -18, -31, 17, 15, -16, -27, -25, 10, 21 }, 21)]
        [TestCase(new int[] { -27, -18, 31, 17, 15, -16, -37, -25, 10, 21 }, 31)]
        [TestCase(new int[] { 0, -18, -31, -31, 15, -16, -27, -25, 21, 21 }, 21)]
        [TestCase(new int[] { 1, 1, 1, 1 }, 1)]
        public void FindMaxElement_WhenArrNotEmptyAndNull_ShouldReturnElement
            (int[] arr, int expected)
        {
            int actual = SingleDimentionalArrayHelper.FindMaxElement(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { -37, -18, -31, 17, 15, -16, -27, -25, 10, 21 }, -21)]
        [TestCase(new int[] { 0, -18, -31, -31, 15, -16, -27, -25, 21, 21 }, -69)]
        [TestCase(new int[] { 1, 1, 1, 1 }, 2)]
        public void CalcSumOddElements_WhenArrNotNull_ShouldReturnSum
            (int[] arr, int expected)
        {
            int actual = SingleDimentionalArrayHelper.CalcSumOddElements(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void CalcSumOddElements_WhenArrIsNull_ShouldThrowException
            (int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                SingleDimentionalArrayHelper.CalcSumOddElements(arr);
            });
        }

        [TestCase(new int[] { -37, -18, -31, 17, 15, -16, -27, -25, 10, 21 }, 
            new int[] { 21, 10, -25, -27, -16, 15, 17, -31, -18, -37 })]
        [TestCase(new int[] { 0, -18, -31, 15, -16, -27, -25, 21, 21 }, 
            new int[] { 21, 21, -25, -27, -16, 15, -31, -18, 0 })]
        [TestCase(new int[] { 1, 1 }, new int[] { 1, 1 })]
        public void ReverseArray_WhenArrNotNull_ShouldReturnReversedArray
            (int[] arr, int[] expected)
        {
            int[] actual = SingleDimentionalArrayHelper.ReverseArray(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void ReverseArray_WhenArrIsNull_ShouldThrowException
            (int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                SingleDimentionalArrayHelper.ReverseArray(arr);
            });
        }

        [TestCase(new int[] { -37, -18, -31, 17, 15, -16, -27, -25, 10, 21 }, -67)]
        [TestCase(new int[] { 0, -18, -31, 15, -16, -27, -25, 21, 21 }, -26)]
        [TestCase(new int[] { 1, 1, 1, 1}, 4)]
        public void CountOddElements_WhenArrNotNull_ShouldReturnSumOddElements
            (int[] arr, int expected)
        {
            int actual = SingleDimentionalArrayHelper.CountOddElements(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void CountOddElements_WhenArrIsNull_ShouldThrowException
            (int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                SingleDimentionalArrayHelper.CountOddElements(arr);
            });
        }

        [TestCase(new int[] { -37, -18, -31, 17, 15, -16, -27, -25, 10, 21 }, 
            new int[] { -16, -27, -25, 10, 21, -37, -18, -31, 17, 15 })]
        [TestCase(new int[] { 0, -18, -31, 15, -16, -27, -25, 21, 21 }, 
            new int[] { -27, -25, 21, 21, -16, 0, -18, -31, 15 })]
        [TestCase(new int[] { 1, 1, 2, 1 }, new int[] { 2, 1, 1, 1 })]
        public void SwapHalfs_WhenArrNotNull_ShouldSwap
            (int[] arr, int[] expected)
        {
            int[] actual = SingleDimentionalArrayHelper.SwapHalfs(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void SwapHalfs_WhenArrNotNull_ShouldThrowException
            (int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                SingleDimentionalArrayHelper.SwapHalfs(arr);
            });
        }

        [TestCase(new int[] { -37, -18, -31, 17, 15, -16, -27, -25, 10, 21 },
            new int[] { -37, -31, -27, -25, -18, -16, 10, 15, 17, 21 })]
        [TestCase(new int[] { 0, -18, -31, 15, -16, -27, -25, 21, 21 },
            new int[] { -31, -27, -25, -18, -16, 0, 15, 21, 21 })]
        [TestCase(new int[] { 1, 1, 2, 1 }, new int[] { 1, 1, 1, 2 })]
        public void SortSelection_WhenArrNotNull_ShouldSort
            (int[] arr, int[] expected)
        {
            int[] actual = SingleDimentionalArrayHelper.SortSelection(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void SortSelection_WhenArrIsNull_ShouldThrowException
            (int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                SingleDimentionalArrayHelper.SwapHalfs(arr);
            });
        }

        [TestCase(new int[] { -37, -18, -31, 17, 15, -16, -27, -25, 10, 21 },
            new int[] { 21, 17, 15, 10, -16, -18, -25, -27, -31, -37 })]
        [TestCase(new int[] { 0, -18, -31, 15, -16, -27, -25, 21, 21 },
            new int[] { 21, 21, 15, 0, -16, -18, -25, -27, -31 })]
        [TestCase(new int[] { 1, 1, 2, 1 }, new int[] { 2, 1, 1, 1 })]
        public void SortDescend_WhenArrNotNull_ShouldSortInDescentOrder
            (int[] arr, int[] expected)
        {
            int[] actual = SingleDimentionalArrayHelper.SortDescend(arr);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null)]
        public void SortDescend_WhenArrIsNull_ShouldThrowException
            (int[] arr)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                SingleDimentionalArrayHelper.SwapHalfs(arr);
            });
        }
    }
}
