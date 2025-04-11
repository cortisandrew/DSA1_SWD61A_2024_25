using Trees;


BinaryMinHeap minHeap = new BinaryMinHeap();

int n = 10;
Random rand = new Random();
List<int> randomIntegers = new List<int>();
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