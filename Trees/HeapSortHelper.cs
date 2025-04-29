using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class HeapSortHelper
    {
        /// <summary>
        /// Be aware that this method will change the value in the parameter!
        /// </summary>
        /// <param name="nums"></param>
        public void HeapSort(int[] nums)
        {
            BinaryMinHeap heap = new BinaryMinHeap();

            // n elements total
            foreach (int x in nums)
            {
                // log n time per element
                heap.Add(x);
            }

            // n elements
            for (int i = 0; i < nums.Length; i++)
            {
                // log n time per element
                nums[i] = heap.RemoveMin();
            }
        }
    }
}
