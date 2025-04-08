using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
