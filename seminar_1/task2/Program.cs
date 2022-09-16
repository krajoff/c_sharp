Console.Clear();
Console.Write("Input first number: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Input second number: ");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB) 
    Console.WriteLine($"max = {numberA}");
else if (numberA < numberB)   
    Console.WriteLine($"max = {numberB}");
else 
    Console.WriteLine($"That is {numberA}={numberB}");