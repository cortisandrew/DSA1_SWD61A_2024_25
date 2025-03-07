using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs_and_DS.Linked_Lists
{
    /// <summary>
    /// A node in a singly linked list that stores an element of type T
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SinglyLinkedListNode<T>
    {
        public T Element { get; internal set; }

        /// <summary>
        /// The next node in the linked list (only if it exists)
        /// If this is the Tail (i.e. last node in the linked list, there is no next node)
        /// In this case, we will use a Null
        /// </summary>
        public SinglyLinkedListNode<T>? Next { get; internal set; }


        public SinglyLinkedListNode(T element, SinglyLinkedListNode<T>? next = null)
        {
            Element = element;
            Next = next;
        }
    }
}
