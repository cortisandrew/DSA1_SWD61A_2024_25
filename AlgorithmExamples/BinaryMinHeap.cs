using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmExamples
{
    public class BinaryMinHeap
    {
        private List<int> heap = new List<int>(); // an ArrayBasedVector to store the information for the heap

        private int LeftChildIndex(int parentIndex)
        {
            return (2 * parentIndex) + 1;
        }

        private int RightChildIndex(int parentIndex)
        {
            return (2 * parentIndex) + 2;
        }

        public int ParentIndex(int childIndex)
        {
            return (childIndex - 1) / 2;
        }
    }
}
