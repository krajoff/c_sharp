// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы: 2 4 .. 3 2 и 3 4 .. 3 3. Результирующая матрица будет: 18 20 .. 15 18
using System;
using static System.Console;

Clear();
Write("Введите размерность первого двумерного массива через пробел (строк и столбцов): ");
int[] sizeFirst = GetSizeArrayFromString(ReadLine());
int[,] arrayFirst = GetRandomTwoDimensionalArray(sizeFirst, 1, 9);
Write("Введите размерность второго двумерного массива через пробел (строк и столбцов): ");
int[] sizeSecond = GetSizeArrayFromString(ReadLine());
int[,] arraySecond = GetRandomTwoDimensionalArray(sizeSecond, 1, 9);
DisplayTwoDimentionalArray(arrayFirst);
WriteLine(" * ");
DisplayTwoDimentionalArray(arraySecond);
MultiplyArray(arrayFirst, arraySecond);

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

void MultiplyArray(int[,] aFirst, int[,] aSecond)
{
    if (aFirst.GetLength(1) != aSecond.GetLength(0))
        Write("Матрицы не совместимы");
    else
    {
        int[,] result = new int[aFirst.GetLength(0), aSecond.GetLength(1)];
        WriteLine("=");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                for (int k = 0; k < aFirst.GetLength(1); k++)
                {
                    result[i, j] += aFirst[i, k] * aSecond[k, j];
                }
            }
        }
    DisplayTwoDimentionalArray(result);
    }
}