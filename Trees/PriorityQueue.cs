using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    /// <summary>
    /// Highest Priority out first - lower value of key indicates higher priority!
    /// </summary>
    public class PriorityQueue
    {
        private BinaryMinHeap heap = new BinaryMinHeap();

        void Enqueue(int key)
        {
            heap.Add(key);
        }

        int Dequeue()
        {
            return heap.RemoveMin();
        }
    }
}
