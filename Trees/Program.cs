using Trees;


BinaryMinHeap minHeap = new BinaryMinHeap();

int n = 10;
Random rand = new Random();
List<int> randomIntegers = new List<int>();
// Because of ToString, avoid adding duplicate values!
for (int i = 0; i < n; i++)
{
    int newValue = rand.Next(1, 20);
    if (!randomIntegers.Contains(newValue))
    {
        minHeap.Add(newValue);
        randomIntegers.Add(newValue);
    }
}

Console.WriteLine(minHeap);

Console.Clear();
Console.WriteLine(minHeap.RemoveMin());
Console.WriteLine(minHeap);


Console.Clear();
randomIntegers.Clear();

//  repeat n times
for (int i = 0; i < n; i++)
{
    int newValue = rand.Next(1, 20);
    randomIntegers.Add(newValue); // log(n)
}

// total work for the previous loop is O(n x log(n))

List<int> output = new List<int>();

// there are n elements,
// the while loop will repeat n times
while (!minHeap.IsEmpty())
{
    output.Add(
        minHeap.RemoveMin()); // log(n)
}
// total work for the while loop is O(n x log(n))


// n x log(n) + n x log(n)
// O(n x log(n))


Console.WriteLine(String.Join(",", output));

Console.WriteLine("End");


/*

BinarySearchTree<string> bst = new BinarySearchTree<string>();

bst.Add(1, "One");
bst.Add(2, "Two");
bst.Add(3, "Three");
bst.Add(5, "Five");
bst.Add(10, "Ten");

Console.WriteLine("End");

*/