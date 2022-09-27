// Напишите цикл, который принимает на вход два числа  
// (A и B)и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Введите первое число: "); 
int A = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: "); 
int B = int.Parse(Console.ReadLine());
Console.Write($"Результат: {Math.Pow(A,B)}");