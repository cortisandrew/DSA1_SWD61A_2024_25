// See https://aka.ms/new-console-template for more information
using ADTs_and_DS.Interfaces;
using ADTs_and_DS.Linked_Lists;
using ADTs_and_DS.Stacks_and_Queues_using_ABV;
using ADTs_and_DS.Stacks_and_Queues_using_LinkedLists;
using ADTs_and_DS.VectorImplementations;
using System.Diagnostics;


Queue_using_LinkedList<string> _queue = new Queue_using_LinkedList<string>();

_queue.Enqueue("A");
_queue.Enqueue("B");
_queue.Enqueue("C");

Console.WriteLine(_queue.Dequeue());
Console.WriteLine(_queue.Dequeue());
Console.WriteLine(_queue.Dequeue());


int numberOfElementsToEnqueue = 100000;

Queue_using_LinkedList<int> _queueInt = new Queue_using_LinkedList<int>();

Stopwatch _stopwatch = new Stopwatch();

for (int i = 0;  i < numberOfElementsToEnqueue; i++)
{
    _stopwatch.Start();
    _queueInt.Enqueue(i);
    _stopwatch.Stop();
}

while (!_queue.IsEmpty())
{
    _stopwatch.Start();
    _queue.Dequeue();
    _stopwatch.Stop();
}

// About 17 seconds before implementing the Tail
// After maintaining a Tail of list, the total time is about 5ms
Console.WriteLine(_stopwatch.ElapsedMilliseconds);



// TestSinglyLinkedList();




//Stack_ABV_test();



//ABV_test();

ArrayBasedVector<int> CreateABVWithCount(int n)
{
    ArrayBasedVector<int> output = new ArrayBasedVector<int>(2 * n);

    for (int i = 0; i < n; i++)
    {
        output.InsertElementAtRank(i, 1);
    }

    return output;
}

void ABV_test()
{
    ArrayBasedVector<string> arrayBasedVector = new ArrayBasedVector<string>(new[] { "Dave", "Bernice", "Eve", "Charles", "Adam" });

    Console.WriteLine(arrayBasedVector);

    #region GetElementAtRank examples
    int rank = 2;
    Console.WriteLine($"The element at rank {rank} is {arrayBasedVector.GetElementAtRank(rank)}");

    rank = 0;
    Console.WriteLine($"The element at rank {rank} is {arrayBasedVector.GetElementAtRank(rank)}");

    rank = 4;
    Console.WriteLine($"The element at rank {rank} is {arrayBasedVector.GetElementAtRank(rank)}");

    try
    {
        rank = -1;
        Console.WriteLine($"The element at rank {rank} is {arrayBasedVector.GetElementAtRank(rank)}");
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
    }
    #endregion

    #region InsertElementAtRankExamples
    arrayBasedVector.InsertElementAtRank(2, "Mavis");

    Console.WriteLine(arrayBasedVector);

    arrayBasedVector.InsertElementAtRank(0, "Fred");

    Console.WriteLine(arrayBasedVector);

    arrayBasedVector.InsertElementAtRank(7, "George");
    Console.WriteLine(arrayBasedVector);
    #endregion

    Console.WriteLine($"Removing element at rank 1. Element removed is {arrayBasedVector.RemoveElementAtRank(1)}");
    Console.WriteLine(arrayBasedVector);

    Console.Clear();


    // I will be creating arrays of different lenghts
    // Create operations for these lengths - compare the time for each operation and each problem size
    int[] arraySizes = new int[] { 100, 200, 300, 400 };
    int valueToInsert = 11;

    foreach (int n in arraySizes)
    {
        ArrayBasedVector<int> abv = CreateABVWithCount(n);
        int timeToInsert = abv.InsertElementAtRankTwo(0, valueToInsert);

        Console.WriteLine(timeToInsert);
    }
}

static void Stack_ABV_test()
{
    int number_of_elements_to_push = 100000;
    Stack_using_ABV<string> _stack = new Stack_using_ABV<string>();
    _stack.Push("A");
    _stack.Push("B");
    _stack.Push("C");
    _stack.Push("D");

    while (!_stack.IsEmpty())
    {
        Console.WriteLine(_stack.Pop());
    }


    Stack_using_ABV<int> myStack = new Stack_using_ABV<int>();

    Stopwatch stopwatch = new Stopwatch();

    for (int i = 0; i < number_of_elements_to_push; i++)
    {
        stopwatch.Start();
        myStack.Push(i);
        stopwatch.Stop();
    }

    while (!myStack.IsEmpty())
    {
        stopwatch.Start();
        myStack.Pop();
        stopwatch.Stop();
    }

    Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
}

static void TestSinglyLinkedList()
{
    SinglyLinkedList<string> mySinglyLinkedList = new SinglyLinkedList<string>();

    mySinglyLinkedList.InsertFirst("C");
    mySinglyLinkedList.InsertFirst("B");
    mySinglyLinkedList.InsertFirst("A");

    Console.WriteLine(mySinglyLinkedList);
}