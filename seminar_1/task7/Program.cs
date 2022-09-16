Console.Clear();
Console.Write("Input number: ");
int n = int.Parse(Console.ReadLine());
if(n<100 || n>999) {
    Console.WriteLine("Incorrent number");
    return;
}
Console.Write("Result: ");  
int a = n/10, b = n - a*10;
int div = n%10;
Console.Write(div);  