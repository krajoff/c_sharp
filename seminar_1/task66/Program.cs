// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120 | M = 4; N = 8. -> 30
using System;
using static System.Console;

Clear();
Write("Введите два натуральных числа через пробел: ");
int[] numbers = GetNumbersFromString(ReadLine());
numbers = CheckSequence(numbers);
int sum = 0;
Write(GetSumNumbers(numbers[0], numbers[1]).ToString());

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

int GetSumNumbers(int end, int start)
{
    if (end == start)
        return sum += start;
    sum += start; return GetSumNumbers(end, start + 1);
}