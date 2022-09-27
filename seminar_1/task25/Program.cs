Console.Clear();
Console.Write("Введите первое число: "); 
int A = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: "); 
int B = int.Parse(Console.ReadLine());
Console.Write($"Результат: {Math.Pow(A,B)}");