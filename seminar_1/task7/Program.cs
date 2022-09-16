Console.Clear();
Console.Write("Input number: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Result: ");  
int a = n/10, b = n - a*10;
int div = n%10;
Console.Write(div);  