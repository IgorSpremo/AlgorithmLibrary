using AlgorithmLibrary.BinarySearch;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace AlgorithmsUnitTestsApplication
{
    [TestFixture]
    public class BinarySearchTest
    {

        #region Find in array tests

        [Test]
        public void Find67InArrayTest()
        {
            int[] primaryNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int actualIndex = BinarySearch<int>.FindElement(primaryNumbers, 67);
            int expectedIndex = 18;

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [Test]
        public void Find62InArrayTest()
        {
            int[] primaryNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int actualIndex = BinarySearch<int>.FindElement(primaryNumbers, 62);
            int expectedIndex = -1;

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [Test]
        public void FindNullInArrayTest()
        {
            Age[] ages = new Age[25];

            for (int i = 0; i < 25; i++)
            {
                ages[i] = new Age();
                ages[i].Value = 25 - i;
            }

            Assert.Throws(typeof(ArgumentNullException), () => BinarySearch<Age>.FindElement(ages, null));
        }

        [Test]
        public void Find1InNullArrayTest()
        {
            int[] primaryNumbers = null;
            Assert.Throws(typeof(ArgumentNullException), () => BinarySearch<int>.FindElement(primaryNumbers, 1));
        }

        [Test]
        public void Find1InEmptyArrayTest()
        {
            int[] primaryNumbers = { };
            Assert.Throws(typeof(ArgumentException), () => BinarySearch<int>.FindElement(primaryNumbers, 1));
        }

        #endregion


        #region Find in list tests

        [Test]
        public void Find67InListTest()
        {
            List<int> primaryNumbers = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int actualIndex = BinarySearch<int>.FindElement(primaryNumbers, 67);
            int expectedIndex = 18;

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [Test]
        public void Find62InListTest()
        {
            List<int> primaryNumbers = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int actualIndex = BinarySearch<int>.FindElement(primaryNumbers, 62);
            int expectedIndex = -1;

            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [Test]
        public void FindNullInListTest()
        {
            List<Age> ages = new List<Age>(25);

            for (int i = 0; i < 25; i++)
            {
                ages.Add(new Age() { Value = 25 - 1 });
            }

            Assert.Throws(typeof(ArgumentNullException), () => BinarySearch<Age>.FindElement(ages, null));
        }

        [Test]
        public void Find1InNullListTest()
        {
            List<int> primaryNumbers = null;
            Assert.Throws(typeof(ArgumentNullException), () => BinarySearch<int>.FindElement(primaryNumbers, 1));
        }

        [Test]
        public void Find1InEmptyListTest()
        {
            int[] primaryNumbers = { };
            Assert.Throws(typeof(ArgumentException), () => BinarySearch<int>.FindElement(primaryNumbers, 1));
        }

        #endregion


        private class Age : IComparable
        {
            public int Value
            {
                get;
                set;
            }

            public int CompareTo(object obj)
            {
                return (obj as Age).Value.CompareTo(Value);
            }
        }
    }
}
