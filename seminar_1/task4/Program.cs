Console.Clear();
Console.Write("Input first number: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Input second number: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Input third number: ");
int numberC = int.Parse(Console.ReadLine());

if (numberA>numberB && numberA>numberC)
    Console.WriteLine($"max = {numberA}");
else if (numberB>numberA && numberB>numberC)
    Console.WriteLine($"max = {numberB}");
else if (numberC>numberA && numberC>numberA)
    Console.WriteLine($"max = {numberC}");
else
    return;
