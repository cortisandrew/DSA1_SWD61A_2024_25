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

        private const int INITIAL_LENGTH = 5;

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
            // Validation
            if (rank < 0 || rank >= count)
            {
                // this element at the rank being passed as a parameter does not exist!
                // Remember: the rank of the 1st element is 0, the rank of the last element is count - 1
                throw new ArgumentOutOfRangeException(nameof(rank), $"The acceptable values for rank are between 0 and {count - 1}.");
            }

            // The element at the rank passed as a parameter is at index rank
            return array[rank];
        }
        public bool IsEmpty()
        {
            // the ABV is empty when the number of elements is 0
            /*
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            */

            // Equivalent to the code above.
            return count == 0;
        }

        /// <summary>
        /// The operation takes an element and places the element in the position indicated by the rank
        /// Since there may be other elements (at the rank and behind the given rank), we need to make space for the new element
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="element"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void InsertElementAtRank(int rank, T element)
        {
            // Validation
            if (rank < 0 || rank > count)
            {
                // Possible positions are between rank 0 (first element) and count (this mean we will append the new element)
                throw new ArgumentOutOfRangeException(nameof(rank), $"The acceptable values for rank are between 0 and {count}.");
            }

            // Check whether the array is full
            if (array.Length == count)
            {
                // the array is full

                // Create a new array which is twice the size of the original array
                T[] newArray = new T[array.Length * 2];

                // Copy everything over
                array.CopyTo( newArray, 0 );

                /* Easier to read the above call, in reality, we are copying all the elements over to the new array
                // Equivalent to the CopyTo method...
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                */

                // replace the array with the new, larger array
                array = newArray;
            }

            // There is now available space...

            // Add some code here to shift the elements

            // This code causes a problem! We would overwrite our data...
            /* Bug in this code!
            for (int i = rank; i < count; i++)
            {
                array[i + 1] = array[i];
            }
            */

            // start shifting from the last element (at count - 1),
            // keep shifting until the position at rank is freed
            for (int i = count - 1; i >= rank; i--)
            {
                array[i + 1] = array[i];
            }

            // place the new element in the correct position
            array[rank] = element;
            // there is now 1 new element, so increment count
            count++;
        }


        public T RemoveElementAtRank(int rank)
        {
            T elementToBeRemoved = GetElementAtRank(rank);

            for (int i = rank; i < count - 1; i++)
            {
                array[i] = array[i + 1];
            }

            // remove the value stored where the last element was before
            array[count - 1] = default!;

            count--;
            return elementToBeRemoved;
        }

        /// <summary>
        /// 1. Check whether the rank passed as a parameter is valid!
        /// 2. Get the element you find at rank
        /// 3. Copy the new element to the rank
        /// 4. Return the old element
        /// </summary>
        /// <param name="rank">The rank of the element to be replaced</param>
        /// <param name="newElement">The new element to replace the old element at the given rank</param>
        /// <returns>The old element that was found at the rank</returns>
        /// <exception cref="NotImplementedException">Exercise for you!</exception>
        public T ReplaceElementAtRank(int rank, T newElement)
        {
            throw new NotImplementedException("Exercise! To do by 24th February (or next lecture)");
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
