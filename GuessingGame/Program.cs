using GuessingGame;
using System.Diagnostics;

//List<int> times = TestAlgorithmA();

int problemSize = 1024*1024*1024;
int runs = problemSize;

/*
SecretNumber s = new SecretNumber(problemSize);
AlgorithmB b = new AlgorithmB(s);
(int, int) result = b.Guess();
Console.WriteLine($"Algorithm B has completed successfully! The secret number is {result.Item1} and it took {result.Item2} guesses to find!");
*/

List<int> times = new List<int>();

for (int i = 0; i < runs; i++)
{
    SecretNumber s = new SecretNumber(problemSize, i + 1);
    AlgorithmB a = new AlgorithmB(s);
    (int, int) result = a.Guess();
    times.Add(result.Item2);
}

Console.WriteLine($"The mean time to find the secret number is {times.Average()}");

static List<int> TestAlgorithmA()
{
    // problem size (the maximum secret number)
    int problemSize = 1000;
    int runs = problemSize;

    List<int> times = new List<int>();

    for (int i = 0; i < runs; i++)
    {
        SecretNumber s = new SecretNumber(problemSize, i + 1);
        AlgorithmA a = new AlgorithmA(s);
        (int, int) result = a.Guess();
        times.Add(result.Item2);
    }

    return times;
}

//Console.WriteLine($"Algorithm A has completed successfully! The secret number is {result.Item1} and it took {result.Item2} guesses to find!");
