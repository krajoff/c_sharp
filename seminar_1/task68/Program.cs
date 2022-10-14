// Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9 | m = 3, n = 2 -> A(m,n) = 29
using System;
using static System.Console;

Clear();
Write("Введите два натуральных числа через пробел: ");
int[] numbers = GetNumbersFromString(ReadLine());
Write(Ackermann(numbers[0], numbers[1]).ToString());

int[] GetNumbersFromString(string numbers)
{
    string[] size = numbers.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[size.Length];
    for (int i = 0; i < result.Length; i++)
        result[i] = int.Parse(size[i]);
    return result;
}

int Ackermann(int m, int n)
{
    if (m > 0)
    {
        if (n > 0)
            return Ackermann(m - 1, Ackermann(m, n - 1));
        else if (n == 0)
            return Ackermann(m - 1, 1);
    }
    else if (m == 0)
            return n + 1;
    throw new System.ArgumentOutOfRangeException();
}