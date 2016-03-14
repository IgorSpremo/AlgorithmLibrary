using System;
using NUnit.Framework;
using AlgorithmLibrary.Collections;

namespace AlgorithmsUnitTestsApplication
{
    [TestFixture]
    public class StackTest
    {
        private Stack<int> CreateStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            stack.Push(5);
            stack.Push(2);
            stack.Push(3);
            stack.Push(1);
            stack.Push(4);
            stack.Push(8);
            stack.Push(9);
            stack.Push(14);
            stack.Push(44);
            stack.Push(95);
            stack.Push(12);

            return stack;
        }

        [Test]
        public void PushTest()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(2);

            Assert.AreEqual(1, stack.Count);
        }

        [Test]
        public void ConstructorWithNoParametersTest()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            stack.Push(5);
            stack.Push(2);
            stack.Push(3);
            stack.Push(1);
            stack.Push(4);
            stack.Push(8);
            stack.Push(9);
            stack.Push(14);
            stack.Push(44);
            stack.Push(95);
            stack.Push(12);


            Assert.IsNotNull(stack);
            Assert.AreEqual(12, stack.Count);
        }

        [Test]
        public void ConstructorWithParametersTest()
        {
            Stack<int> stack = new Stack<int>(7);
            stack.Push(0);
            stack.Push(5);
            stack.Push(2);
            stack.Push(3);
            stack.Push(1);
            stack.Push(4);

            Assert.IsNotNull(stack);

            int expectedCount = 6;
            Assert.AreEqual(expectedCount, stack.Count);
        }

        [Test]
        public void CopyConstructorTest()
        {
            Stack<int> firstStack = new Stack<int>();
            firstStack.Push(1);
            firstStack.Push(5);
            firstStack.Push(2);
            firstStack.Push(3);
            firstStack.Push(0);
            firstStack.Push(4);

            Stack<int> secondStack = new Stack<int>(firstStack);

            Assert.IsNotNull(firstStack);
            Assert.AreEqual(6, secondStack.Count);
            Assert.AreEqual(firstStack, secondStack);
        }

        [Test]
        public void CloneMethodTest()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(5);
            stack.Push(2);
            stack.Push(3);
            stack.Push(0);
            stack.Push(4);

            Stack<int> clonedStack = stack.Clone() as Stack<int>;

            Assert.AreEqual(stack, clonedStack);
        }

        [Test]
        public void PopTest()
        {
            Stack<int> stack = CreateStack();
            int expectedCount = 7;
            int expectedValue = 9;

            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            int actualValue = stack.Pop();

            Assert.AreEqual(expectedCount, stack.Count);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void PopEmptyStackTest()
        {
            Stack<float> stack = new Stack<float>();

            Assert.Throws(typeof(InvalidOperationException), () => stack.Pop());
        }

        [Test]
        public void ResizeToBiggerTest()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int expectedCount = 3;
            int expectedCapacity = 4;

            Assert.AreEqual(expectedCount, stack.Count);
            Assert.AreEqual(expectedCapacity, stack.Capacity);
        }

        [Test]
        public void ResizeToSmallerTest()
        {
            Stack<int> stack = CreateStack();

            for (int i = 0; i < 8; i++)
            {
                stack.Pop();
            }

            int expectedCapacity = 8;
            int expectedCount = 4;

            Assert.AreEqual(expectedCount, stack.Count);
            Assert.AreEqual(expectedCapacity, stack.Capacity);
        }
    }
}
