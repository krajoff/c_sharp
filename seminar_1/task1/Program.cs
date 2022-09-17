Console.Clear();
Console.WriteLine("Input first number: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Input second number: ");
int numberB = int.Parse(Console.ReadLine());

// no comments
// no comments


if(numberA == Convert.ToInt32(Math.Pow(numberB, 2))) {
    Console.WriteLine($"{numberA} is square of {numberB}");
    }
else {
    Console.WriteLine($"{numberA} is not square of {numberB}");
}


