using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibrary.Sorting
{
    /// <summary>
    /// A generic class that contains implemented sorting methods: 
    ///     * QuickSort, 
    ///     * MergeSort, 
    ///     * HeapSort, 
    ///     * ShellSort
    /// </summary>
    public class SorterClass<T> where T : IComparable
    {

        public SorterClass()
        {

        }

        #region Quick sort

        public static void QuickSort(T[] arrayToSort)
        {
            QuickSort<T>.Sort(arrayToSort);
        }
        
        #endregion


        #region Merge sort

        public static void MergeSort(T[] arrayToSort)
        {
            MergeSort<T>.Sort(arrayToSort, MergeSort<T>.ASCENDING);
        }

        #endregion


        #region Heap sort

        public T[] HeapSort(T[] arrayToSort)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> HeapSort(ICollection<T> collectionToSort)
        {
            throw new NotImplementedException();
        }

        #endregion


        #region Shell sort

        public T[] ShellSort(T[] arrayToSort)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ShellSort(ICollection<T> collectionToSort)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
