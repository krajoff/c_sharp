// Задача 64: Задайте значения N, М. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до M. Выполнить с помощью рекурсии.
// N = 5, M = 2 -> "5, 4, 3, 2," N = 8, M = 4 -> "8, 7, 6, 5, 4"
using System;
using static System.Console;

Clear();
Write("Введите два натуральных числа через пробел: ");
int[] numbers = GetNumbersFromString(ReadLine());
numbers = CheckSequence(numbers);
Write(GetRowValues(numbers[0], numbers[1]));

int[] GetNumbersFromString(string numbers)
{
    string[] size = numbers.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[size.Length];
    for (int i = 0; i < result.Length; i++)
        result[i] = int.Parse(size[i]);
    return result;
}

int[] CheckSequence(int[] numbers)
{
    if (numbers[1] > numbers[0])
    {
        int temp = numbers[1];
        numbers[1] = numbers[0];
        numbers[0] = temp;
    }
    return numbers;
}

string GetRowValues(int n, int m)
{
    if (n == m) 
        return (n.ToString());
    return (GetRowValues(n, m + 1) + ", " + m.ToString());
}