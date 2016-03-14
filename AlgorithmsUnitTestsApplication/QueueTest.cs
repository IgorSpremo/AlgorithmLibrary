using System;
using NUnit.Framework;
using AlgorithmLibrary.Collections;

namespace AlgorithmsUnitTestsApplication
{
    [TestFixture]
    public class QueueTest
    {

        private Queue<int> CreateQueue()
        {
            Queue<int> q = new Queue<int>(5);

            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(7);
            q.Enqueue(4);
            q.Enqueue(5);

            return q;
        }

        [Test]
        public void ConstructorWithNoParametersTest()
        {
            Queue<int> q = new Queue<int>();

            int expectedCount = 0;
            int expectedCapacity = 1;

            int actualCount = q.Count;
            int actualCapacity = q.Capacity;

            Assert.IsNotNull(q);
            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedCapacity, actualCapacity);
        }

        [Test]
        public void ConstructorWithCapacityParameterTest()
        {
            Queue<int> q = new Queue<int>(5);

            int expectedCount = 0;
            int expectedCapacity = 5;

            int actualCount = q.Count;
            int actualCapacity = q.Capacity;

            Assert.IsNotNull(q);
            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedCapacity, actualCapacity);
        }

        [Test]
        public void EnqueueTest()
        {
            Queue<int> q = CreateQueue();
            q.Enqueue(6);

            int expectedCount = 6;
            int expectedCapacity = 10;

            int actualCount = q.Count;
            int actualCapacity = q.Capacity;

            Assert.IsNotNull(q);
            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedCapacity, actualCapacity);
        }

        [Test]
        public void CopyConstructorTest()
        {
            Queue<int> q1 = CreateQueue();

            Queue<int> q2 = new Queue<int>(q1);

            int expectedCount = 5;
            int expectedCapacity = 5;

            int actualCapacity = q2.Capacity;
            int actualCount = q2.Count;

            Assert.IsNotNull(q2);
            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedCapacity, actualCapacity);
        }

        [Test]
        public void DequeueTest()
        {
            Queue<int> q = CreateQueue();

            int[] expectedData = new int[5] { 1, 2, 7, 4, 5 };
            int expectedCount1 = 5;
            int expectedCount2 = 3;
            int expectedCount3 = 1;
            int expectedCount4 = 0;

            int expectedCapacity1 = 5;
            int expectedCapacity2 = 2;

            int actualCount1 = q.Count;
            int actualCapacity1 = q.Capacity;
            int[] actualData = new int[5];


            actualData[0] = q.Dequeue();
            actualData[1] = q.Dequeue();
            int actualCount2 = q.Count;
            int actualCapacity2 = q.Capacity;
            actualData[2] = q.Dequeue();
            actualData[3] = q.Dequeue();
            int actualCount3 = q.Count;
            int actualCapacity3 = q.Capacity;
            actualData[4] = q.Dequeue();
            int actualCapacity4 = q.Capacity;
            int actualCount4 = q.Count;


            Assert.IsNotNull(q);

            Assert.AreEqual(expectedCount1, actualCount1);
            Assert.AreEqual(expectedCount2, actualCount2);
            Assert.AreEqual(expectedCount3, actualCount3);
            Assert.AreEqual(expectedCount4, actualCount4);

            Assert.AreEqual(expectedCapacity1, actualCapacity1);
            Assert.AreEqual(expectedCapacity1, actualCapacity2);
            Assert.AreEqual(expectedCapacity1, actualCapacity3);
            Assert.AreEqual(expectedCapacity2, actualCapacity4);

            CollectionAssert.AreEqual(expectedData, actualData);
        }

        [Test]
        public void CapacityTest()
        {
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < 513; i++)
            {
                q.Enqueue(i);
            }

            // 1024 jer ga svaki put duplira kada predje kapacitet niza...
            int expectedCapacity1 = 1024;
            int expectedCapacity2 = 2;

            int actualCapacity1 = q.Capacity;
            for (int i = 0; i < 513; i++)
            {
                q.Dequeue();
            }
            int actualCapacity2 = q.Capacity;

            Assert.AreEqual(expectedCapacity1, actualCapacity1);
            Assert.AreEqual(expectedCapacity2, actualCapacity2);
        }

        [Test]
        public void ToArrayTest()
        {
            Queue<int> q = CreateQueue();

            int[] expectedArray = new int[5] { 1, 2, 7, 4, 5 };
            int[] actualArray = q.ToArray();

            CollectionAssert.AreEquivalent(expectedArray, actualArray);
        }

        [Test]
        public void ClearTest()
        {
            Queue<int> q = CreateQueue();
            q.Clear();


            int expectedCount = 0;
            int expectedCapacity = 5;

            int actualCount = q.Count;
            int actualCapacity = q.Capacity;

            Assert.AreEqual(expectedCapacity, actualCapacity);
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void PeekTest()
        {
            Queue<int> q = CreateQueue();

            int expectedValue = 1;

            int actualValue = q.Peek();

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void DequeueEmptyQueueTest()
        {
            Queue<int> queue = new Queue<int>();

            Assert.Throws(typeof(InvalidOperationException), () => queue.Dequeue());
        }
    }
}
