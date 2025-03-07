using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs_and_DS.Linked_Lists
{
    public class SinglyLinkedList<T>
    {
        private SinglyLinkedListNode<T>? head;

        // private SinglyLinkedListNode<T>? tail;

        private int count = 0;

        public int Count { get { return count; } }

        public bool IsEmpty { get { return count == 0; } }

        public SinglyLinkedListNode<T>? Head { get; private set; }

        public SinglyLinkedListNode<T>? Tail { get; private set; }

        /// <summary>
        /// Insert a new element and place it at the head of list
        /// </summary>
        /// <param name="element"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void InsertFirst(T element)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Insert a new element at the tail of list
        /// </summary>
        /// <param name="element"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void InsertLast(T element)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove the element at the head of list
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public T RemoveFirst() { throw new NotImplementedException(); }

        /// <summary>
        /// Remove the element at the tail of list
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public T RemoveLast() {  throw new NotImplementedException(); }

        public void InsertAfter(SinglyLinkedListNode<T> cursor, T element)
        {
            throw new NotImplementedException();
        }

        public bool InsertBefore(SinglyLinkedListNode<T> cursor, T eleent)
        {
            throw new NotImplementedException();
        }
    }
}
