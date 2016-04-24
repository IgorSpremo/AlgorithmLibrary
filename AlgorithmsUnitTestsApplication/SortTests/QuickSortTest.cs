using System;
using AlgorithmLibrary.Sorting;
using NUnit.Framework;

namespace AlgorithmsUnitTestsApplication.SortTests
{
    [TestFixture]
    public class QuickSortTest
    {

        [Test]
        public void SortIntArrayTest()
        {
            int[] actualArray = { 6, 3, 8, 2, 1, 4, 7, 5 };

            SorterClass<int>.QuickSort(actualArray);

            int[] expectedResult = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Assert.AreEqual(expectedResult, actualArray);
        }

        [Test]
        public void SortOneElementArrayTest()
        {
            int[] actualArray = { 6 };

            SorterClass<int>.QuickSort(actualArray);

            int[] expectedResult = { 6 };

            Assert.AreEqual(expectedResult, actualArray);
        }

        [Test]
        public void SortEmptyArrayTest()
        {
            int[] actualArray = { };

            SorterClass<int>.QuickSort(actualArray);

            int[] expected = { };

            Assert.AreEqual(expected, actualArray);
        }

        [Test]
        public void SortNullTest()
        {
            int[] actualArray = null;
            Assert.Throws(typeof(ArgumentNullException), () => SorterClass<int>.QuickSort(actualArray));
        }

    }
}
