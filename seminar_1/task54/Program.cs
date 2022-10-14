// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива. Например, задан массив:
// 1 4 7 2 ...  5 9 2 3 ...  8 4 2 4 В итоге получается вот такой массив:
// 7 4 2 1 ...  9 5 3 2 ...  8 4 4 2
using System;
using static System.Console;

Clear();
Write("Введите размерность двумерного массива через пробел (строк и столбцов): ");
int[] size = GetSizeArrayFromString(ReadLine());
int[,] array = GetRandomTwoDimensionalArray(size, 0, 9);
DisplayTwoDimentionalArray(array);
WriteLine();
DisplayTwoDimentionalArray(SortArrayByRow(array));

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

int[,] SortArrayByRow(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}