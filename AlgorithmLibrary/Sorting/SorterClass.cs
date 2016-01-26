using System;
using System.Collections.Generic;
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
    public class SorterClass<T> : IDisposable
    {

        public SorterClass()
        {

        }

        public void Dispose()
        {
            
        }

        #region Quick sort

        public T[] QuickSort(T[] arrayToSort)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> QuickSort(ICollection<T> collectionToSort)
        {
            throw new NotImplementedException();
        }

        #endregion


        #region Merge sort

        public T[] MergeSort(T[] arrayToSort)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> MergeSort(ICollection<T> collectionToSort)
        {
            throw new NotImplementedException();
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
