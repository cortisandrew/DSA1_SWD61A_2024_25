using ADTs_and_DS.Linked_Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTs_and_DS.Stacks_and_Queues_using_LinkedLists
{
    /// <summary>
    /// TODO: Exercise 1: Implement a stack using a singly linked list
    /// Exercise 2: With a SINGLY linked list, why are we using InsertLast and RemoveFirst? (instead of InsertFirst and RemoveLast) // to attempt after adding the Tail
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Queue_using_LinkedList<T>
    {
        private SinglyLinkedList<T> linkedList = new SinglyLinkedList<T>();

        public int Count { get { return linkedList.Count; } }

        public bool IsEmpty() { return linkedList.IsEmpty; }


        // Add the new element to the end of the queue
        public void Enqueue(T element)
        {
            linkedList.InsertLast(element);
        }

        public T Dequeue()
        {
            return linkedList.RemoveFirst();
        }
    }
}
