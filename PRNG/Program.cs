// See https://aka.ms/new-console-template for more information
using PRNG;

Console.WriteLine("Hello, World!");

LCG lCG = new LCG();

for (int i = 0; i < 50; i++)
{
    Console.WriteLine(lCG.Next(1, 7));
}