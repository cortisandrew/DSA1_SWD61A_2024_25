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

        private SinglyLinkedListNode<T>? tail;

        private int count = 0;

        public int Count { get { return count; } }

        public bool IsEmpty { get { return count == 0; } }

        public SinglyLinkedListNode<T>? Head { 
            get { return head; }
            private set { head = value; }
        }

        public SinglyLinkedListNode<T>? Tail
        {
            get { return tail; }
            private set { tail = value; }
        }

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

            // Special Case, Linked List is empty!
            // In this case, the newNode being added will be BOTH the first node and the last node
            if (head == null)
            {
                // This is the special case!
                tail = newNode;
            }

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
            /* Old version before we had the tail of list
            // the list is NOT empty... therefore there is at least one element/node
            SinglyLinkedListNode<T> cursor = head;

            // we want to move forward, until, the cursor == "tail"
            // the tail node has a Next value equal to null

            // while cursor is NOT equal to the tail
            while (cursor.Next != null) // cursor != tail
            {
                // try the next node: move one step forward
                cursor = cursor.Next;
            }
            */

            // the cursor is equal to the tail
            SinglyLinkedListNode<T> cursor = tail!; // there is at least 1 element, therefore, the tail exists!

            // now the new element can be added in a node AFTER the tail
            InsertAfter(cursor, element);
        }

        /// <summary>
        /// Remove the element at the head of list
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public T RemoveFirst() {

            // Step (0): Validation
            // Case (a) - the linked list is empty
            if (head==null) // count == 0
            {
                throw new InvalidOperationException("You cannot remove an element from an empty linked list!");
            }

            // Case (b) 1 element and (c) more than one element
            // Work in almost the same way

            // Step (i): Get the element to return
            T elementToReturn = head.Element;

            // Step (ii): Update the Head of list to point to Head.Next
            head = head.Next;   // Move the head one step forward

            // Special case: last element removed
            if (head == null)
            {
                tail = null; // this means that even the tail is removed!
            }

            // Step (iii)
            count--;

            // Step (iv)
            return elementToReturn;
            
        }

        /// <summary>
        /// Remove the element at the tail of list
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public T RemoveLast() {  throw new NotImplementedException(); }

        public void InsertAfter(SinglyLinkedListNode<T> cursor, T element)
        {
            // Validation
            // Step (0)
            // cursor must NOT be equal to NULL
            if (cursor == null)
            {
                throw new ArgumentNullException(nameof(cursor), "You cannot insert after a NULL!");
            }

            // Step (i)
            // Create a new Node to place after the cursor
            SinglyLinkedListNode<T> newNode = new SinglyLinkedListNode<T>(element);

            // Step (ii)
            // Update the newNode.Next value
            newNode.Next = cursor.Next;

            // Special case: Cursor is the last element
            if (cursor.Next == null) // cursor == tail
            {
                // the new Node is being added AFTER the last element
                tail = newNode; // updated the tail to point towards the new last element of the list!
            }

            // Step (iii)
            // Change the value of existing references
            // Cursor.Next has to point to the new node
            cursor.Next = newNode;

            // Step (iv)
            // Increment count
            count++;
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
