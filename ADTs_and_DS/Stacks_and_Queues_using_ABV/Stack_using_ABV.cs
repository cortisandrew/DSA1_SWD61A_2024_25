using ADTs_and_DS.VectorImplementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs_and_DS.Stacks_and_Queues_using_ABV
{
    /// <summary>
    /// Store elements of type T
    /// Elements are returned in a Last In First Out order
    /// (The element at the top of the stack is the most recent and will be removed first before other elements)
    /// </summary>
    public class Stack_using_ABV<T>
    {
        private ArrayBasedVector<T> _abv = new ArrayBasedVector<T>();

        public int Count { get { return _abv.Count; } }

        public bool IsEmpty() { return _abv.IsEmpty(); }

        /// <summary>
        /// Add a new element to the top of the stack.
        /// </summary>
        /// <param name="element"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Push(T element) {
            _abv.InsertElementAtRank(Count, element);
            // Inefficient option!
            // _abv.InsertElementAtRank(0, element);
        }

        /// <summary>
        /// Remove the most recent element (which is found at the top of the stack)
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public T Pop()
        {
            return _abv.RemoveElementAtRank(Count - 1);
            // Inefficient option!
            //return _abv.RemoveElementAtRank(0);
        }

        /// <summary>
        /// Look at the item at the top of the stack, without removing it
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public T Peek()
        {
            return _abv.GetElementAtRank(Count - 1);
        }
    }
}
