using ADTs_and_DS.VectorImplementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs_and_DS.Stacks_and_Queues_using_ABV
{
    /// <summary>
    /// A data structure that stores elements of type T
    /// Elements are enqueued and then removed (dequeued) in a
    /// First In First Out order (i.e. longest waiting time gets removed first)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Queue_using_ABV<T>
    {
        private ArrayBasedVector<T> _abv = new ArrayBasedVector<T>();

        public int Count { get { return _abv.Count; } }

        public bool IsEmpty() { return _abv.IsEmpty(); }


        public void Enqueue(T element)
        {
            // Option i) Place the newest element at the last position of the array (Fast)
            // _abv.InsertElementAtRank(Count, element);

            // Option ii) Place the newest element at position 0 of the array (Slow)
            _abv.InsertElementAtRank(0, element);
        }

        public T Dequeue() {
            // Option i) The element that has been waiting the longest is at position 0 (Slow! - we need to shift all the other elements)
            // return _abv.RemoveElementAtRank(0);

            // Option ii) Fast
            return _abv.RemoveElementAtRank(Count - 1);
        }

        public T Peek() {
            // Option ii)
            return _abv.GetElementAtRank(Count - 1);
        }
    }
}
