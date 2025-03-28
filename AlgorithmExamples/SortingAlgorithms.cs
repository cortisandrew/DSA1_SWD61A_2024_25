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
            int[] p1 = a.Take(n / 2);
            int[] p2 = a.Skip(n / 2).Take(n - (n / 2));

            // Recursive calls (x2 calls with length about n/2)
            int[] p1_sorted = MergeSort(p1);
            int[] p2_sorted = MergeSort(p2);

            return merge(p1_sorted,
                         p2_sorted);
        }

        protected static int[] merge(int[] p1_sorted, int[] p2_sorted)
        {
            int[] output = new int[p1_sorted.Length + p2_sorted.Length];

            // Magic happens...

            return output;
        }

    }
}
