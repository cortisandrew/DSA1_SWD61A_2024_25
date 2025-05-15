using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees;

namespace AlgorithmExamples
{
    public class SortingAlgorithms
    {

        public static int[] MergeSort(int[] a)
        {
            int n = a.Length;

            // Stopping condition: a is trivially sorted
            if (n <= 1)
            {
                return a;
            }
            // else, n > 1, we may need to sort...

            // Split a into 2 (almost) equal parts
            int[] p1 = a.Take(n / 2).ToArray();
            int[] p2 = a.Skip(n / 2).Take(n - (n / 2)).ToArray();

            // Recursive calls (x2 calls with length about n/2)
            int[] p1_sorted = MergeSort(p1);
            int[] p2_sorted = MergeSort(p2);

            return merge(p1_sorted,
                         p2_sorted);
        }

        /// <summary>
        /// The inputs MUST be sorted, otherwise, the Merge will NOT work
        /// </summary>
        /// <param name="p1_sorted">A sorted array</param>
        /// <param name="p2_sorted">A sorted array</param>
        /// <returns></returns>
        protected static int[] merge(int[] p1_sorted, int[] p2_sorted)
        {
            int[] output = new int[p1_sorted.Length + p2_sorted.Length];

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < p1_sorted.Length && j < p2_sorted.Length) 
            {
                // compare the elements at location i and j
                if (p1_sorted[i] <= p2_sorted[j])
                {
                    // copy p1_sorted[i] to the output
                    output[k]= p1_sorted[i];
                    i++;
                }
                else
                {
                    // p2_sorted[j] is SMALLER than p1_sorted[i]
                    output[k] = p2_sorted[j];
                    j++; // p2_sorted[j] is already copied. We now look at the next element in p2_sorted
                }

                k++; // output[k] is occupied, the next available position is k+1
            }

            while (i < p1_sorted.Length)
            {
                // there are still elements from p1_sorted to copy
                // copy them all!
                output[k] = p1_sorted[i];
                i++;
                k++;
            }

            while (j < p2_sorted.Length)
            {
                // there are still elements from p1_sorted to copy
                // copy them all!
                output[k] = p2_sorted[j];
                j++;
                k++;
            }

            return output;
        }


        public static void QuickSort(int[] a)
        {
            // Start a quicksort on the array from position 0 to position length - 1 (both inclusive)
            quickSort(a, 0, a.Length - 1);
        }

        private static void quickSort(int[] a, int lo, int hi)
        {
            // stopping condition
            if (hi <= lo)
            {
                return;
            }

            // These two steps are included in a single method call
            // Step 1: Select pivot
            // Step 2: Partition
            
            // The return value is the index of the pivot AFTER partitioning!
            int pivotIndex = SelectPivotAndPartition(a, lo, hi);

            // any values in positions lo up to pivotIndex - 1, are smaller than the pivot
            quickSort(a, lo, pivotIndex - 1);

            // any values in positions pivotIndex + 1 up to hi, are larger than the pivot
            quickSort(a, pivotIndex + 1, hi);

            // when the method ends, all elements between lo and hi are sorted
        }

        private static int SelectPivotAndPartition(int[] a, int lo, int hi)
        {
            // this extra code, will select an element at random and swap it with the leftmost position
            // this ensure that the pivot selected will be chosen at random
            // swap a random element with the lo position
            // adding this line is equivalent to selecting a pivot at random
            // a.Swap(lo, Random.Shared.Next(lo, hi + 1));

            // leftmost pivot
            int pivotIndex = lo;
            int pivotValue = a[pivotIndex];

            // compare every element between lo and hi (inclusive) against the pivot
            // place all the elements smaller than the pivot to the "left"
            // all elements larger (or equal) than the pivot to the "right"

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = lo; i <= hi; i++)
            {
                if (i == pivotIndex)
                    continue;

                // compare element at position i (from lo to hi INCLUSIVE) with the pivot
                if (a[i] < pivotValue)
                {
                    left.Add(a[i]);
                }
                else // a[i] >= pivotValue
                {
                    right.Add(a[i]);
                }
            }

            // place everything back in order
            left.CopyTo(a, lo);
            int finalPivotIndex = lo + left.Count;
            a[finalPivotIndex] = pivotValue;
            right.CopyTo(a, finalPivotIndex + 1);

            return finalPivotIndex;
        }
    }
}
