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

        //public SinglyLinkedListNode<T>? Tail { get; private set; }

        /// <summary>
        /// Insert a new element and place it at the head of list
        /// </summary>
        /// <param name="element"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void InsertFirst(T element)
        {
            // Step (i): Build the new instance of the Node
            SinglyLinkedListNode<T> newNode = new SinglyLinkedListNode<T>(element);
            
            // Step (ii): Update the Next of the newNode to point towards the old Head of list
            // Notice, this will work, even if head == null
            newNode.Next = head;

            // Step (iii): Update the head of list
            // Notice that this will destroy the previous links
            head = newNode;

            // Step (iv): Increment count
            count++;
        }

        /// <summary>
        /// Insert a new element at the tail of list
        /// </summary>
        /// <param name="element"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void InsertLast(T element)
        {
            // Case (a): 
            // the list is currently empty
            if (head==null) // count == 0
            {
                // that is, we need to add the last element to an empty list
                // creating a list of length 1
                // this only element, will be BOTH the first and last element

                // Special case: this is equivalent to InsertFirst
                InsertFirst(element);
                return; // the above call will have met all the requirements, make sure to end the operation
                        // to avoid fall-through
            }

            // Case (b): this is equivalent to InsertAfter(tail, element)
            // the list is NOT empty... therefore there is at least one element/node
            SinglyLinkedListNode<T> cursor = head;

            // we want to move forward, until, the cursor == "tail"
            // the tail node has a Next value equal to null

            // while cursor is NOT equal to the tail
            while (cursor.Next != null)
            {
                // try the next node: move one step forward
                cursor = cursor.Next;
            }

            // the cursor is equal to the tail
            // cursor = tail;

            // now the new element can be added in a node AFTER the tail
            InsertAfter(cursor, element);
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

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            List<T> elements = new List<T>();

            SinglyLinkedListNode<T>? cursor = head;

            // while we still have at least one element to read
            while (cursor != null)
            {
                elements.Add(cursor.Element); // copy the element

                cursor = cursor.Next; // move forward one step
            }

            stringBuilder.Append("[ ");
            stringBuilder.Append(String.Join(", ", elements));
            stringBuilder.Append(" ]");

            return stringBuilder.ToString();
        }
    }
}
