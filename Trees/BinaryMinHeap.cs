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

        /// <summary>
        /// Because of the complete property, the height is O(log(n))
        /// Therefore, Upheap goes up one level with each call
        /// Worst call, it recursively calls itself log(n) times
        /// Therefore, Add has a worst case O(log(n))
        /// </summary>
        /// <param name="value"></param>
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

        /// <summary>
        /// O(log(n)) worst case
        /// </summary>
        /// <returns></returns>
        public int RemoveMin()
        {
            int minValue = arrayBasedVector[0];

            // copy the last value to the root
            arrayBasedVector[0] = 
                arrayBasedVector[arrayBasedVector.Count - 1];

            // remove the last element
            arrayBasedVector.RemoveAt(arrayBasedVector.Count - 1);

            // tree is complete, but we may not have Heap order

            DownHeap(0);

            return minValue;
        }

        /// <summary>
        /// Since the height is O(log(n)), this method is recursively called, O(log(n)) worst case
        /// </summary>
        /// <param name="index"></param>
        private void DownHeap(int index)
        {
            // case i: no children, i.e. leaf node
            int leftChildIndex = LeftChildIndex(index);

            // the last element of the tree is at index
            // arrayBasedVector.Count - 1
            if (leftChildIndex >= arrayBasedVector.Count)
            {
                // there is no left child
                // (this also means that I have no right child)
                return;
            }

            int smallestChildIndex = -1;

            // case ii: exactly one child
            if (leftChildIndex == arrayBasedVector.Count - 1)
            {
                // the left child is exactly the last element of the array
                smallestChildIndex = leftChildIndex;
            } // case iii: two children
            else // leftChildIndex < arrayBasedVector.Count - 1
            {
                // we have both children
                int rightChildIndex = RightChildIndex(index);

                if (arrayBasedVector[leftChildIndex] <= arrayBasedVector[rightChildIndex])
                {
                    // left child is <= right child
                    smallestChildIndex = leftChildIndex;
                }
                else
                {
                    // rightChild > left child
                    smallestChildIndex = rightChildIndex;
                }
            }

            if (arrayBasedVector[index] > arrayBasedVector[smallestChildIndex])
            {
                // we do not have heap-order
                // a larger value is on top of a smaller value
                arrayBasedVector.Swap(index, smallestChildIndex);
                DownHeap(smallestChildIndex);
                return;
            }
            else
            {
                // smaller value is on top
                // heap-order is restored!
                return;
            }
        }

        /// <summary>
        /// Requires elements to be unique to work (otherwise we get issues with the graph)
        /// ASSUMES: That there are no duplicate keys...
        /// </summary>
        /// <returns></returns>
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

        internal bool IsEmpty()
        {
            return arrayBasedVector.Count == 0;
        }
    }
}
