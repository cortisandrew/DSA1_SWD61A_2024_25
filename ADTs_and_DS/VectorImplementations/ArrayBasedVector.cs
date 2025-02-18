using ADTs_and_DS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs_and_DS.VectorImplementations
{
    /// <summary>
    /// A concrete implementation of the IVectorADT.
    /// The ArrayBasedVector will use an array to store the elements of the Vector
    /// </summary>
    /// <typeparam name="T">The data type of the elements that are to be stored</typeparam>
    public class ArrayBasedVector<T> : IVectorADT<T>
    {
        // public int Count { get; private set; } = 0;

        /// <summary>
        /// Stores the number of elements in the array
        /// </summary>
        private int count = 0;

        public int Count { 
            get { 
                return count; 
            }
            private set
            {
                count = value;
            }
        }

        private const int INITIAL_LENGTH = 8;

        /// <summary>
        /// The array that will store our elements (of type T)
        /// </summary>
        private T[] array;

        public ArrayBasedVector(int initialLength = INITIAL_LENGTH)
        {
            array = new T[initialLength];
            count = 0;
        }

        public ArrayBasedVector(T[] elements, int initialLength = INITIAL_LENGTH)
        {
            if (elements.Length > initialLength)
            {
                throw new ArgumentException("The number of elements that you want to store is larger than the underlying array!", nameof(initialLength));
            }

            array = new T[initialLength];

            for (int i = 0; i < elements.Length; i++)
            {
                array[i] = elements[i];
                count++;
            }
        }

        public T GetElementAtRank(int rank)
        {
            throw new NotImplementedException();
        }

        public void InsertElementAtRank(int rank, T element)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public T RemoveElementAtRank(int rank)
        {
            throw new NotImplementedException();
        }

        public T ReplaceElementAtRank(int rank, T newElement)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("[");

            sb.Append(
                String.Join(", ", array.Take(count))
                );

            sb.Append("]");

            return sb.ToString();
        }
    }
}
