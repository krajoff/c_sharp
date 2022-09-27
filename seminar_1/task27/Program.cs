// Напишите программу, которая принимает на вход число и выдыёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int sum = 0;
while(num > 0) {
    sum += num % 10;
    num /= 10;
}
Console.Write($"Результат: {sum}");