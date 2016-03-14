using AlgorithmLibrary.Collections;
using NUnit.Framework;
using System.Collections.Generic;

namespace AlgorithmsUnitTestsApplication
{
    [TestFixture]
    public class BinaryHeapTest
    {
        [Test]
        public void TestCountZero()
        {
            BinaryHeap<double> heap = new BinaryHeap<double>();

            int actual = heap.Count;
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCountTwo()
        {
            BinaryHeap<double> heap = new BinaryHeap<double>();

            heap.Insert(0);
            heap.Insert(1);

            int actual = heap.Count;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestPopFirst()
        {
            BinaryHeap<double> heap = new BinaryHeap<double>();

            heap.Insert(1);
            heap.Insert(0);
            heap.Insert(2);
            heap.Insert(-2);

            double actual = heap.Pop();
            double expected = -2;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestPopLast()
        {
            BinaryHeap<double> heap = new BinaryHeap<double>();

            heap.Insert(1);
            heap.Insert(0);
            heap.Insert(2);
            heap.Insert(-2);

            heap.Pop();
            heap.Pop();
            heap.Pop();

            double actual = heap.Pop();
            double expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestPeekFirst()
        {
            BinaryHeap<double> heap = new BinaryHeap<double>();

            heap.Insert(1);
            heap.Insert(0);
            heap.Insert(2);
            heap.Insert(-2);

            double actual = heap.Peek();
            double expected = -2;

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void TestPeekSecond()
        {
            BinaryHeap<double> heap = new BinaryHeap<double>();

            heap.Insert(1);
            heap.Insert(0);
            heap.Insert(2);
            heap.Insert(-2);

            heap.Pop();
            double actual = heap.Peek();
            double expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestPeekLast()
        {
            BinaryHeap<double> heap = new BinaryHeap<double>();

            heap.Insert(1);
            heap.Insert(0);
            heap.Insert(2);
            heap.Insert(-2);

            heap.Pop();
            heap.Pop();
            heap.Pop();

            double actual = heap.Peek();
            double expected = 2;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestArrayContructor()
        {
            int[] array = { 6, 5, 4, 3, 2, 1 };
            BinaryHeap<int> heap = new BinaryHeap<int>(array, 6);

            int actual = heap.Pop();
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCollectionContructor()
        {
            List<int> list = new List<int>() { 6, 5, 4, 3, 2, 1 };
            BinaryHeap<int> heap = new BinaryHeap<int>(list);

            int actual = heap.Pop();
            int expected = 1;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TestCapacityOne()
        {
            BinaryHeap<int> heap = new BinaryHeap<int>();

            heap.Insert(0);

            int actual = heap.Capacity;
            int expected = 1;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TestCapacitySixteen()
        {
            BinaryHeap<int> heap = new BinaryHeap<int>();

            heap.Insert(0);
            heap.Insert(1);
            heap.Insert(2);
            heap.Insert(3);
            heap.Insert(3);
            heap.Insert(0);
            heap.Insert(1);
            heap.Insert(2);
            heap.Insert(3);
            heap.Insert(3);

            int actual = heap.Capacity;
            int expected = 16;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TestResizeCapacityDownToEight()
        {
            BinaryHeap<int> heap = new BinaryHeap<int>();

            heap.Insert(0);
            heap.Insert(1);
            heap.Insert(2);
            heap.Insert(3);
            heap.Insert(3);
            heap.Insert(0);
            heap.Insert(1);
            heap.Insert(2);
            heap.Insert(3);
            heap.Insert(3);

            heap.Pop();
            heap.Pop();
            heap.Pop();
            heap.Pop();
            heap.Pop();
            heap.Pop();
            heap.Pop();

            int actual = heap.Capacity;
            int expected = 8;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void ResizeToBiggerTest()
        {
            BinaryHeap<int> heap = new BinaryHeap<int>();
            heap.Insert(3);
            heap.Insert(2);
            heap.Insert(1);

            int expectedCount = 3;
            int expectedCapacity = 4;

            Assert.AreEqual(expectedCount, heap.Count);
            Assert.AreEqual(expectedCapacity, heap.Capacity);
        }

        [Test]
        public void ResizeToSmallerTest()
        {
            BinaryHeap<int> heap = new BinaryHeap<int>();
            heap.Insert(3);
            heap.Insert(2);
            heap.Insert(1);
            heap.Insert(3);
            heap.Insert(2);
            heap.Insert(1);
            heap.Insert(3);
            heap.Insert(2);
            heap.Insert(1);
            heap.Insert(3);
            heap.Insert(2);
            heap.Insert(1);

            for (int i = 0; i < 9; i++)
            {
                heap.Pop();
            }

            int expectedCount = 3;
            int expectedCapacity = 8;

            Assert.AreEqual(expectedCount, heap.Count);
            Assert.AreEqual(expectedCapacity, heap.Capacity);
        }

    }
}
