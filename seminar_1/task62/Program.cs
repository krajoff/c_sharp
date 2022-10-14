// Напишите программу, которая заполнит спирально массив 4 на 4. Например, 
// на выходе получается вот такой массив: 01 02 03 04 ... 12 13 14 05
// 11 16 15 06 ... 10 09 08 07
using System;
using static System.Console;

Clear();
int[] size = { 4, 4 };
int[,] array = GetRandomTwoDimensionalArray(size, 10, 100);
WriteLine("Исходный массив: ");
DisplayTwoDimentionalArray(array);
WriteLine("Массив с элементами по спирали: ");
int[] sortRow = SortRow(ConvertArrayToRow(array));
DisplayTwoDimentionalArray(GetHelixArrayFromRow(sortRow, size));

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

int[] ConvertArrayToRow(int[,] array)
{
    int[] result = new int[array.GetLength(0) * array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            result[i * array.GetLength(1) + j] = array[i, j];
    }
    return result;
}

int[] SortRow(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        for (int k = j + 1; k < array.Length; k++)
        {
            if (array[k] < array[j])
            {
                int temp = array[j];
                array[j] = array[k];
                array[k] = temp;
            }
        }
    }
    return array;
}

void DisplayRow(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
}

int[,] GetHelixArrayFromRow(int[] row, int[] size)
{
    int[,] result = new int[size[0], size[1]];
    int startRow = 0; int endRow = size[0] - 1;
    int startColumn = 0; int endColumn = size[1] - 1;
    int k = 0;
    while (startRow < endRow && startColumn < endColumn)
    {

        for (int i = startColumn; i <= endColumn; i++)
        {
            result[startRow, i] = row[k];
            k++;
        }
        startRow += 1;
        for (int i = startRow; i <= endRow; i++)
        {
            result[i, endColumn] = row[k];
            k++;
        }
        endColumn -= 1;
        for (int i = endColumn; i >= startColumn; i--)
        {
            result[endRow, i] = row[k];
            k++;
        }
        endRow -= 1;
        for (int i = endRow; i >= startRow; i--)
        {
            result[i, startColumn] = row[k];
            k++;
        }
        startColumn += 1;
    }
    return result;
}