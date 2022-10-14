// Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов. Например, задан массив:
// 1 4 7 2 ... 5 9 2 3 ... 8 4 2 4 ... 5 2 6 7 Программа считает сумму элементов 
// в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
using System;
using static System.Console;

Clear();
Write("Введите размерность двумерного массива через пробел (строк и столбцов): ");
int[] size = GetSizeArrayFromString(ReadLine());
int[,] array = GetRandomTwoDimensionalArray(size, 0, 9);
DisplayTwoDimentionalArray(array);
GetLowerSumByRow(array);

int[] GetSizeArrayFromString(string stringSize)
{
    string[] size = stringSize.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[size.Length];
    for (int i = 0; i < result.Length; i++)
        result[i] = int.Parse(size[i]);
    return result;
}

int[,] GetRandomTwoDimensionalArray(int[] size, int min, int max)
{
    int[,] array = new int[size[0], size[1]];
    for (int i = 0; i < size[0]; i++)
        for (int j = 0; j < size[1]; j++) array[i, j] = new Random().Next(min, max);
    return array;
}

void DisplayTwoDimentionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
}

void GetLowerSumByRow(int[,] array)
{
    int lowRange = 0;
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        if (i == 0) temp = sum;
        if (i > 0 && sum < temp)
        {
            lowRange = i;
            temp = sum;
        }
    }
    Write($"Номер строки с наименьшей суммой элементов: {lowRange} строка (отчёт от 0)");
}