using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmLibrary.Sorting
{
    class QuickSort<T> where T : IComparable
    {
        private static Random rnd = new Random();

        public static void Sort(T[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            if (array.Length > 1)
            {
                Sort(array, 0, array.Length - 1);
            }
        }

        private static void Sort(T[] array, int low, int high)
        {
            if (high - low < 2)
            {
                return;
            }

            int p = Partition(array, low, high);

            Sort(array, low, p);
            Sort(array, p, high);

        }

        /// <summary>
        /// Partitions the given array instance arround the pivot element which is at the 'pivotIndex' position.
        /// </summary>
        /// 
        /// <param name="array">
        /// An instance of ICollection to be partitioned.
        /// </param>
        /// 
        /// <param name="leftMostIndex">
        /// An index that represents the begining of the partitioning part of the collection and the separator index between
        /// elements that are greater then the pivot element and the elements that are less then the pivot element.
        /// </param>
        /// 
        /// <param name="rightMostIndex">
        /// An index of end of the partitioning section.
        /// </param>
        /// 
        /// <param name="pivotIndex">
        /// An index of the pivot element.
        /// </param>
        private static int Partition(T[] array, int leftMostIndex, int rightMostIndex)
        {
            int p = rnd.Next(rightMostIndex - leftMostIndex) + leftMostIndex;
            T pivot = array[p];
            Swap(array, p, leftMostIndex);

            int i = leftMostIndex + 1;
            for (int j = leftMostIndex + 1; j <= rightMostIndex; j++)
            {
                int comparisonResult = array[j].CompareTo(pivot);
                if (comparisonResult < 0)   // If the element is smaller then the pivot element...
                {
                    Swap(array, j, i);
                    i++;
                }
                else if (comparisonResult == 0) // If the element is equal to the pivot element...
                {

                }
            }

            Swap(array, leftMostIndex, --i);

            return i;
        }

        #region Swap methods
        
        /// <summary>
        /// If the indexes are in range, swaps two elements at the indexes 'indexOfElementA' and 'indexOfElementB'.
        /// Otherwise throws an IndexOutOfRangeException for the index that is out of range.
        /// 
        /// NOTE: If the 'indexOfElementA' is out of range, the 'indexOfElementB' will not be checked.
        /// </summary>
        /// <param name="array">An array containing the elements to swap.</param>
        /// <param name="indexOfElementA">An index of first element.</param>
        /// <param name="indexOfElementB">An index of second element.</param>
        private static void Swap(T[] array, int indexOfElementA, int indexOfElementB)
        {
            if (indexOfElementA < 0 || indexOfElementA >= array.Length)
            {
                throw new IndexOutOfRangeException("indexOfElementA is out of range.");
            }

            if (indexOfElementB < 0 || indexOfElementB >= array.Length)
            {
                throw new IndexOutOfRangeException("indexOfElementB is out of range.");
            }

            T tmp = array[indexOfElementA];
            array[indexOfElementA] = array[indexOfElementB];
            array[indexOfElementB] = tmp;
        }

        #endregion

    }
}
