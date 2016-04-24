using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmLibrary.BinarySearch
{
    /// <summary>
    /// A generic class that implements a binary search algorithm.
    /// </summary>
    /// <typeparam name="T">A type of elements in the array that must implement IComparable.</typeparam>
    public class BinarySearch<T> where T : IComparable
    {

        #region Find element in array

        /// <summary>
        /// Finds the given element in a sorted array and returns its index. If the element does not exist, -1 is returned.
        /// </summary>
        /// <param name="array">An array to be searched for the element.</param>
        /// <param name="element">An element to be found in the array.</param>
        /// <returns>An index of the element in the array if it is found; -1 otherwise.</returns>
        public static int FindElement(T[] array, T element)
        {
            if (array == null)
                throw new ArgumentNullException("Input array must not be null.");

            if (array.Length == 0)
                throw new ArgumentException("Input array can not be empty.");

            if (element == null)
                throw new ArgumentNullException("Element to be found can not be null.");

            return Find(array, element, 0, array.Length - 1);
        }

        private static int Find(T[] array, T element, int min, int max)
        {

            if (max - min == 1)
                return -1;

            int index = min + (max - min) / 2;

            int comparisonResult = array[index].CompareTo(element);
            if (comparisonResult > 0) // If indexed element in the array is smaller than element to find
            {
                return Find(array, element, min, index);
            }
            else if (comparisonResult < 0) // If indexed element in the array is bigger than element to find
            {
                return Find(array, element, index, max);
            }
            else // If indexed element in the array is equal to the element to find
            {
                return index;
            }
        }

        #endregion


        /// <summary>
        /// Finds the given element in a sorted array and returns its index. If the element does not exist, -1 is returned.
        /// </summary>
        /// <param name="list">An array to be searched for the element.</param>
        /// <param name="element">An element to be found in the array.</param>
        /// <returns>An index of the element in the array if it is found; -1 otherwise.</returns>
        public static int FindElement(List<T> list, T element)
        {
            if (list == null)
                throw new ArgumentNullException("Input list must not be null.");

            if (list.Count == 0)
                throw new ArgumentException("Input list can not be empty.");

            if (element == null)
                throw new ArgumentNullException("Element to be found can not be null.");

            return Find(list, element, 0, list.Count - 1);
        }

        private static int Find(List<T> list, T element, int min, int max)
        {

            if (max - min == 1)
                return -1;

            int index = min + (max - min) / 2;

            int comparisonResult = list[index].CompareTo(element);
            if (comparisonResult > 0) // If indexed element in the array is smaller than element to find
            {
                return Find(list, element, min, index);
            }
            else if (comparisonResult < 0) // If indexed element in the array is bigger than element to find
            {
                return Find(list, element, index, max);
            }
            else // If indexed element in the array is equal to the element to find
            {
                return index;
            }
        }

    }
}
