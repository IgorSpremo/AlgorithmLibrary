using System;
using System.Collections.Generic;

namespace AlgorithmLibrary.Collections
{
    /// <summary>
    /// A generic binary heap class that stores and sorts elements.
    /// Elements must implement IComparable interface.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryHeap<T> where T : IComparable<T>
    {
        #region Atributes

        /// <summary>
        /// An array containing the data.
        /// </summary>
        private T[] data;

        /// <summary>
        /// The capacity of the array of data elements.
        /// </summary>
        protected int capacity;

        /// <summary>
        /// The number of data elements in array.
        /// </summary>
        protected int currentPosition;

        #endregion

        #region Properties

        /// <summary>
        /// Gets 32-bit integer that represents the total size of allocated data array.
        /// <exception cref="InvalidOperationException">Thrown when <code>set</code> is called with a value that is less than the Capacity value.</exception>
        /// </summary>
        public int Capacity
        {
            get
            {
                return capacity;
            }

            private set
            {
                if (value >= capacity)
                {
                    capacity = value;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }

        /// <summary>
        /// Number of elements in the heap.
        /// </summary>
        public int Count
        {
            get
            {
                return currentPosition + 1;
            }
        }

        #endregion

        #region Constructors

        public BinaryHeap()
        {
            data = new T[1];
            capacity = 1;
            currentPosition = -1;
        }

        public BinaryHeap(T[] data, int capacity)
        {
            this.data = new T[capacity];
            this.capacity = capacity;
            this.currentPosition = -1;

            foreach (T t in data)
            {
                Insert(t);
            }

        }

        public BinaryHeap(T[] data)
        {
            this.data = new T[capacity];
            this.capacity = data.Length;
            this.currentPosition = -1;

            foreach (T t in data)
            {
                Insert(t);
            }

        }

        public BinaryHeap(ICollection<T> data)
        {
            this.data = new T[data.Count];
            capacity = data.Count;
            this.currentPosition = -1;

            foreach (T t in data)
            {
                Insert(t);
            }

        }

        public BinaryHeap(int capacity)
        {
            this.capacity = capacity;
            data = new T[capacity];
            currentPosition = -1;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Inserts the given element in the heap.
        /// </summary>
        /// <param name="t">The element to be insered.</param>
        public void Insert(T t)
        {
            if (currentPosition + 1 >= capacity)
            {
                int newCapacity = (capacity) * 2;
                Resize(newCapacity);
            }

            data[++currentPosition] = t;
            HeapifyUp(currentPosition);
        }

        public T Peek()
        {
            return data[0];
        }

        public T Pop()
        {
            try
            {
                T retVal = data[0];
                data[0] = data[currentPosition];
                data[currentPosition] = default(T);

                currentPosition--;

                HeapifyDown(0);

                if (currentPosition + 1 < capacity / 4)
                {
                    Resize(data.Length / 2);
                }

                return retVal;
            }
            catch (IndexOutOfRangeException e)
            {
                throw e;
            }
        }

        private void HeapifyUp(int childIndex)
        {
            if (childIndex > 0)
            {
                int parentIndex = (childIndex - 1) / 2;
                if (data[childIndex].CompareTo(data[parentIndex]) < 0)
                {
                    T t = data[parentIndex];
                    data[parentIndex] = data[childIndex];
                    data[childIndex] = t;

                    HeapifyUp(parentIndex);
                }
            }
        }

        private void HeapifyDown(int parentIndex)
        {
            int leftChildIndex = parentIndex * 2 + 1;
            int rightChildIndex = leftChildIndex + 1;
            int largestChildIndex = parentIndex;

            if (leftChildIndex <= currentPosition && data[leftChildIndex].CompareTo(data[largestChildIndex]) < 0)
            {
                largestChildIndex = leftChildIndex;
            }
            if (rightChildIndex <= currentPosition && data[rightChildIndex].CompareTo(data[largestChildIndex]) < 0)
            {
                largestChildIndex = rightChildIndex;
            }

            if (largestChildIndex != parentIndex)
            {
                T t = data[parentIndex];
                data[parentIndex] = data[largestChildIndex];
                data[largestChildIndex] = t;
                HeapifyDown(largestChildIndex);
            }
        }

        /// <summary>
        /// Expands the capacity of the array.
        /// </summary>
        private void Resize(int newCapacity)
        {
            capacity = newCapacity;
            T[] newData = new T[capacity];

            Array.Copy(data, newData, currentPosition + 1);

            data = newData;
        }

        #endregion

    }
}
