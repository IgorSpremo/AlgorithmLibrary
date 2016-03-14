using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary.Collections
{
    public class Queue<T>
    {

        #region Atributes

        /// <summary>
        /// A List containing the data of type 'T'.
        /// </summary>
        protected List<T> data;

        #endregion


        #region Properties

        /// <summary>
        ///     Gets or sets the total number of elements the internal data structure can hold without resizing.
        /// </summary>
        /// 
        /// <exception cref="InvalidOperationException">
        ///     Thrown when <code>set</code> is called with a value that is less than the Capacity value.
        /// </exception>
        public int Capacity
        {
            get
            {
                return data.Capacity;
            }

            set
            {
                data.Capacity = value;
            }
        }

        /// <summary>
        ///     Gets the number of elements contained in the Queue.
        /// </summary>
        public int Count
        {
            get
            {
                return data.Count;
            }
        }

        #endregion


        #region Constructors

        public Queue()
        {
            data = new List<T>(1);
        }

        public Queue(int initialCapacity)
        {
            data = new List<T>(initialCapacity);
        }

        public Queue(Queue<T> q)
        {
            data = new List<T>(q.Capacity);
            foreach (var t in q.data)
            {
                data.Add(t);
            }
        }

        #endregion
        ///
        /// <summary>
        ///     Adds an object to the end of the Queue.
        /// </summary>
        /// 
        /// <param name="element">
        ///     The object to add to the Queue. The value can be null for reference types.
        /// </param>
        ///
        public void Enqueue(T element)
        {
            data.Add(element);
        }

        /// 
        /// <summary>
        ///     Removes and returns the object at the beginning of the Queue.
        /// </summary>
        /// 
        /// <returns>
        ///     The object that is removed from the beginning of the Queue.
        /// </returns>
        /// 
        /// <exception cref="InvalidOperationException">
        ///     The Queue is empty.
        /// </exceptions>
        /// 
        public T Dequeue()
        {
            if (Count > 0)
            {
                T retVal = data[0];
                data.RemoveAt(0);

                if (data.Count < data.Capacity / 4)
                {
                    data.Capacity /= 2;
                }

                return retVal;
            }

            throw new InvalidOperationException("The Queue is empty.");
        }


        //
        // Summary:
        //     Returns the object at the beginning of the Queue
        //     without removing it.
        //
        // Returns:
        //     The object at the beginning of the Queue.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The Queue is empty.
        public T Peek()
        {
            if (data == null)
                data = new List<T>(Capacity);

            if (Count > 0)
            {
                return data[0];
            }

            throw new InvalidOperationException("The Queue is empty.");
        }

        //
        // Summary:
        //     Copies the Queue elements to a new array.
        //
        // Returns:
        //     A new array containing elements copied from the Queue.
        public T[] ToArray()
        {
            try
            {
                return data.ToArray();
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //
        // Summary:
        //     Sets the capacity to the actual number of elements in the Queue.
        public void TrimExcess()
        {
            data.TrimExcess();
        }

        //
        // Summary:
        //     Determines whether an element is in the Queue.
        //
        // Parameters:
        //   item:
        //     The object to locate in the Queue. The value can
        //     be null for reference types.
        //
        // Returns:
        //     true if item is found in the Queue; otherwise, false.
        public bool Contains(T item)
        {
            foreach (T dataItem in data)
            {
                if (dataItem.Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        ///     Removes all data from the Queue.
        /// </summary>
        public void Clear()
        {
            data.Clear();
        }

    }
}
