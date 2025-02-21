// See https://aka.ms/new-console-template for more information
using ADTs_and_DS.Interfaces;
using ADTs_and_DS.VectorImplementations;

ArrayBasedVector<string> arrayBasedVector = new ArrayBasedVector<string>( new []{ "Dave", "Bernice", "Eve", "Charles", "Adam" });

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

