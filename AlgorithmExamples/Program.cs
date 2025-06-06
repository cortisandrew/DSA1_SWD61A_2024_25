﻿// See https://aka.ms/new-console-template for more information

using AlgorithmExamples;


List<double> numbersToSort = new List<double>();
for (int i = 0; i < 10; i++)
{
    numbersToSort.Add(10 * Random.Shared.NextDouble());
}


int testRuns = 10;

for (int r = 0; r < testRuns; r++)
{
    List<int> unsortedOriginal = new List<int>();

    int n = 10000;
    int maxValue = 10001;

    for (int i = 0; i < n; i++)
    {
        unsortedOriginal.Add(Random.Shared.Next(maxValue));
    }

    int[] quickSortArray = unsortedOriginal.ToArray();
    SortingAlgorithms.QuickSort(quickSortArray);

    int[] nativeSortArray = unsortedOriginal.ToArray();
    Array.Sort(nativeSortArray);

    if (quickSortArray.SequenceEqual(nativeSortArray))
    {
        Console.WriteLine("Success!");
    }
    else
    {
        Console.WriteLine("Not equal - check your work!");
    }
}
//Console.WriteLine(
//    String.Join(", ", SortingAlgorithms.MergeSort(unsorted)));

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