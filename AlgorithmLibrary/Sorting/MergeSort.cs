using System;

namespace AlgorithmLibrary.Sorting
{
    public class MergeSort<T> where T : IComparable
    {
        public static int ASCENDING = 0;
        public static int DESCENDING = 1;

        public static void Sort(T[] array, int order)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            if (array.Length <= 1)
            {
                return;
            }

            int m = (array.Length + 1) / 2;

            T[] left = SubArray(array, 0, m);
            T[] right = SubArray(array, m, array.Length);

            Sort(left, order);
            Sort(right, order);

            Merge(array, left, right, order);

        }

        private static void Merge(T[] array, T[] left, T[] right, int order)
        {
            int i = 0;
            int j = 0;

            while (i < left.Length || j < right.Length)
            {
                if (i == left.Length)
                {
                    array[i + j] = right[j];
                    j++;
                }
                else if (j == right.Length)
                {
                    array[i + j] = left[i];
                    i++;
                }
                else if (CheckOrder(left[i], right[j], order))
                {
                    array[i + j] = left[i];
                    i++;
                }
                else {
                    array[i + j] = right[j];
                    j++;
                }
            }
        }

        private static T[] SubArray(T[] array, int begin, int end)
        {
            T[] ret = new T[end - begin];
            int i = 0;
            for (; begin < end; begin++)
            {
                ret[i++] = array[begin];
            }

            return ret;
        }

        private static bool CheckOrder(T a, T b, int order)
        {
            int comparisonResult = a.CompareTo(b);

            if (order == ASCENDING)
            {
                if (comparisonResult <= 0)  // if (a <= b) ...
                {
                    return true;
                }

                return false;
            }
            else {
                if (comparisonResult >= 0) // if (a >= b) ...
                {
                    return true;
                }

                return false;
            }

        }

    }
}
