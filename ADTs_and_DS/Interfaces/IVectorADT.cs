using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs_and_DS.Interfaces
{
    /// <summary>
    /// The IVectorADT represents a VectorADT.
    /// The IVectorADT will store an ordered sequence of elements (i.e. like the race results)
    /// The elements will have a rank to describe the order. The rank is the number of elements
    /// preceding the current element.
    /// </summary>
    /// <typeparam name="T">
    /// The type parameter T (the one in the angled brackets) represents the data type of the
    /// elements that are being stored.
    /// The programmer can select the type when he is declaring.
    /// </typeparam>
    public interface IVectorADT<T>
    {
        /// <summary>
        /// Get the number of elements stored in the VectorADT
        /// </summary>
        int Count { get; }
        
        /// <summary>
        /// Returns whether the vector ADT is empty
        /// </summary>
        /// <returns>True if there are 0 elements. False Otherwise.</returns>
        bool IsEmpty();
        
        /// <summary>
        /// Returns the element at a rank passed as a parameter
        /// </summary>
        /// <param name="rank">The rank of the item to be returned</param>
        /// <returns>The item found at the given rank</returns>
        T GetElementAtRank(int rank);

        /// <summary>
        /// Inserts a new element at the rank passed as a parameter
        /// </summary>
        /// <param name="rank">The rank where the new element will be placed</param>
        /// <param name="element">The new element to insert into the VectorADT. The element is of type T, because
        /// the VectorADT is storing elements of type T</param>
        void InsertElementAtRank(int rank, T element);

        /// <summary>
        /// Replaces the element found at the rank passed as a parameter
        /// </summary>
        /// <param name="rank">The rank of the element to be replaced</param>
        /// <param name="newElement">The new element to replace the old element with</param>
        /// <returns>The old element which was replaced</returns>
        T ReplaceElementAtRank(int rank, T newElement);

        /// <summary>
        /// Removes the element found at the rank passed as a parameter
        /// </summary>
        /// <param name="rank">The rank of the element to be removed</param>
        /// <returns>The element which was removed</returns>
        T RemoveElementAtRank(int rank);
    }
}
