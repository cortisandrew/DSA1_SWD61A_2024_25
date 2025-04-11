using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinaryMinHeap
    {
        private List<int> arrayBasedVector = new List<int>(); // an ArrayBasedVector to store the information for the arrayBasedVector

        private int LeftChildIndex(int parentIndex)
        {
            return (2 * parentIndex) + 1;
        }

        private int RightChildIndex(int parentIndex)
        {
            return (2 * parentIndex) + 2;
        }

        private int ParentIndex(int childIndex)
        {
            return (childIndex - 1) / 2;
        }

        public void Add(int value)
        {
            // Add to the last position, to preserve the completeness property
            arrayBasedVector.Add(value);

            // However, the arrayBasedVector might no longer be in arrayBasedVector-order, at the newly added element/value
            Upheap(arrayBasedVector.Count - 1); // perform an upheap starting at the index of the newly added value
        }

        private void Upheap(int index)
        {
            // if index == 0, we are at the root, there is no parent to compare to,
            // therefore, arrayBasedVector-order is restored!
            if (index == 0) return;

            int parentIndex = ParentIndex(index);

            // Compare the value at index, with the value at index of the parent
            // if the value at the index >= the value of the index at the parent, arrayBasedVector-order is restored, we can stop
            if (arrayBasedVector[index] >= arrayBasedVector[parentIndex])
            {
                // arrayBasedVector-order is restored, we are now done!
                return;
            }
            // else, swap the value with that of the parent and keep recursively calling the up-arrayBasedVector at the index of the parent

            // in this case, arrayBasedVector[index] < arrayBasedVector[parentIndex]

            arrayBasedVector.Swap(index, parentIndex);
            Upheap(parentIndex);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            // dictionary mapping index to the key at the given index
            Dictionary<int, int> dict= new Dictionary<int, int>();

            for (int i = 0; i<arrayBasedVector.Count;i++)
            {
                dict.Add(i, arrayBasedVector[i]);
            }

            sb.AppendLine("Graph G {");
            foreach(var kvp in dict)
            {
                sb.AppendLine(kvp.Value.ToString());

                // if this vertex has a left child, add an arrow to the child
                if (LeftChildIndex(kvp.Key)<arrayBasedVector.Count)
                {
                    sb.AppendLine(kvp.Value.ToString() + " -- " + arrayBasedVector[LeftChildIndex(kvp.Key)]);
                }

                // if this vertex has a right child, add an arrow to the child
                if (RightChildIndex(kvp.Key) < arrayBasedVector.Count)
                {
                    sb.AppendLine(kvp.Value.ToString() + " -- " + arrayBasedVector[RightChildIndex(kvp.Key)]);
                }

            }

            sb.AppendLine("}");
            return sb.ToString();
        }
    }
}
