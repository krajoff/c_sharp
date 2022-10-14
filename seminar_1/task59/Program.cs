// Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.
using System;
using static System.Console;

Clear();
Write("Введите размерность двумерного массива через пробел (строк и столбцов): ");
int[] size = GetSizeArrayFromString(ReadLine());
int[,] array = GetRandomTwoDimensionalArray(size, 10, 100);
WriteLine("Исходный массив: ");
DisplayTwoDimentionalArray(array);
WriteLine();
int[] posMin = GetPositionMinimumValue(array);
WriteLine($"Массив после удаления строки {posMin[0]} и столбца {posMin[1]}: ");
DisplayTwoDimentionalArray(RemoveRowColoumByMinimumElement(array, posMin));

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

int[] GetPositionMinimumValue(int[,] array)
{
    int min = array[1, 1];
    int[] result = { 1, 1 };
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                result[0] = i; result[1] = j;
                min = array[i, j];
            }
        }
    }
    return result;
}

int[,] RemoveRowColoumByMinimumElement(int[,] array, int[] minPos)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i < minPos[0])
            {
                if (j < minPos[1]) result[i, j] = array[i, j];
                else if (j > minPos[1]) result[i, j - 1] = array[i, j];
            }
            else if (i > minPos[0])
            {
                if (j < minPos[1]) result[i - 1, j] = array[i, j];
                else if (j > minPos[1]) result[i - 1, j - 1] = array[i, j];
            }
        }
    }
    return result;
}