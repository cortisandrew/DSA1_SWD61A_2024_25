// See https://aka.ms/new-console-template for more information

using AlgorithmExamples;

int[] unsorted = new int[] { 39, 45, 8, 16, 14, 37, 38 };

Console.WriteLine(
    String.Join(", ", SortingAlgorithms.MergeSort(unsorted)));

/*
int[] problemSizes = new int[] { 2, 4, 8, 16, 32, 64, 128 };


foreach (int n in problemSizes) {
    int time = G(n);

    Console.WriteLine($"{n}, {time}");
}
*/

/*
int n = 4;
Console.WriteLine($"{n}, {H(n)}");


int G(int n)
{
    int i = n;
    int sum = 0;

    while (i > 1)
    {
        i = i / 2;
        sum++;
    }

    return sum;
}

int H(int n)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine();
        Console.Write($"i: {i}, j: ");

        for (int j = i; j < n; j++)
        {
            Console.Write($"{j} ");
            sum++;
        }
    }
    Console.WriteLine();
    return sum;
}
*/