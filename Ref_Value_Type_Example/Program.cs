using Ref_Value_Type_Example;

Console.WriteLine("Value Type Variables:");

int a = 5;
int b = 6;

Console.WriteLine($"The value of a is {a}");    // 5
Console.WriteLine($"The value of b is {b}");    // 6

a = b;
Console.WriteLine("a=b");
Console.WriteLine($"The value of a is {a}");    // 6
Console.WriteLine($"The value of b is {b}");    // 6

b = 10;

Console.WriteLine("b=10");
Console.WriteLine($"The value of a is {a}");    // 6
Console.WriteLine($"The value of b is {b}");    // 10

Console.WriteLine();
Console.WriteLine("Reference Type Variables:");

DataClass c = new DataClass(5);
DataClass d = new DataClass(6);

Console.WriteLine($"The value of c is {c.DataValue}");    // 5
Console.WriteLine($"The value of d is {d.DataValue}");    // 6

c = d;
Console.WriteLine("c=d");
Console.WriteLine($"The value of c is {c.DataValue}");    // 6
Console.WriteLine($"The value of d is {d.DataValue}");    // 6

d.DataValue = 10;
Console.WriteLine("d.DataValue = 10");
Console.WriteLine($"The value of c is {c.DataValue}");    // 10
Console.WriteLine($"The value of d is {d.DataValue}");    // 10
