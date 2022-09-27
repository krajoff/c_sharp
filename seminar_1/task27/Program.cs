// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write($"Результат: {GetSum(num)}");

int GetSum(int num)
{
    int sum = 0;
    while(num > 0) {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}