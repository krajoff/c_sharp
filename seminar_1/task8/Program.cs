Console.Clear();
Console.Write("Input number: ");
int n = int.Parse(Console.ReadLine());
if (n < 0) 
    Console.Write("Incorrect number");
else {
    for (int i = 2; i <= n; i = i + 2)
        Console.Write(i+" ");
}