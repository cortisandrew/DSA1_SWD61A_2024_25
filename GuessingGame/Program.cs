using GuessingGame;

SecretNumber s = new SecretNumber(100);
AlgorithmA a = new AlgorithmA(s);
(int, int) result = a.Guess();

Console.WriteLine($"Algorithm A has completed successfully! The secret number is {result.Item1} and it took {result.Item2} guesses to find!");
