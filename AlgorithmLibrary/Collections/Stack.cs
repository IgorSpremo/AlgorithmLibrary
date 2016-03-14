using System;

namespace AlgorithmLibrary.Collections
{
    public class Stack<T> : ICloneable
    {

        #region Atributes

        /// <summary>
        /// An array containing the data.
        /// </summary>
        protected T[] data;

        /// <summary>
        /// The number of data elements in array.
        /// </summary>
        protected int currentPosition;

        #endregion

        #region Properties

        /// <summary>
        /// Number of elements in the stack.
        /// </summary>
        public int Count
        {
            get
            {
                return currentPosition + 1;
            }
        }

        /// <summary>
        /// The size of an array that contains data of the stack.
        /// </summary>
        public int Capacity
        {
            get
            {
                return data.Length;
            }
        }

        #endregion

        public Stack()
        {
            this.data = new T[1];
            currentPosition = -1;
        }

        public Stack(int capacity)
        {
            this.data = new T[capacity];
            currentPosition = -1;
        }

        public Stack(Stack<T> s)
        {
            this.data = (T[])s.data.Clone();
            this.currentPosition = s.currentPosition;
        }

        public void Push(T t)
        {
            if (currentPosition + 1 >= data.Length)
            {
                Resize(data.Length * 2);
            }

            data[++currentPosition] = t;
        }

        public T Pop()
        {
            if (currentPosition < 0)
                throw new InvalidOperationException("Can not call this method when the stack is empty!");

            if (data.Length > ((currentPosition - 1) * 4))
                Resize(data.Length / 2);

            return data[currentPosition--];

        }

        /// <summary>
        /// Changes the capacity of the array.
        /// </summary>
        private void Resize(int newCapacity)
        {
            T[] newData = new T[newCapacity];

            Array.Copy(data, newData, currentPosition + 1);

            data = newData;
        }

        public object Clone()
        {
            Stack<T> clonedStack = new Stack<T>(data.Length);

            for (int i = 0; i < Count; i++)
            {
                clonedStack.Push(data[i]);
            }

            return clonedStack;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }


            Stack<T> objToCheck = obj as Stack<T>;

            if (objToCheck.Count != Count)
                return false;

            if (objToCheck.currentPosition != currentPosition)
                return false;

            for (int i = 0; i < Count; i++)
            {
                if (!data[i].Equals(objToCheck.data[i]))
                    return false;
            }

            return true;

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
