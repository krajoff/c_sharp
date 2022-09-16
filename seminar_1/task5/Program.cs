Console.Clear();
Console.Write("Input number: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Result: ");
for (int i = -n; i < n; i++)
{
    Console.Write(i+",");
} 
Console.Write(n);